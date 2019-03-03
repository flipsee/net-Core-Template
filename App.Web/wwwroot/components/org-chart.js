Vue.component('org-chart', {
  props: {    
    node: {
      type: Array,
      default: null
    },
    base_url: "" 
  },
  template: ` <div class="tree">
                <org-chart-item :node="data" isMainNode>    
                  <!-- Pass on all named slots -->
                  <slot v-for="slot in Object.keys($slots)" :name="slot" :slot="slot"/>

                  <!-- Pass on all scoped slots -->
                  <template v-for="slot in Object.keys($scopedSlots)" :slot="slot" slot-scope="scope"><slot :name="slot" v-bind="scope"/></template>                  
                </org-chart-item>
              </div>`,
  created: function () { 
      this.loadData();
  },
  data: function (){
    return {
      data: this.node
    }
  },
  methods:{
    loadData: function(){
        let self = this;
        if (self.node == null){ 
          axios.get(self.base_url + 'api/org-chart-data-flat.json')
          .then(function (response) {
            // handle success
            //console.log(response);            
            self.$data.data = list_to_tree(response.data);    
            //self.$data.data = unflatten(response.data);           
            //console.log(self.$data.data);
          })
          .catch(function (error) {
            // handle error
            console.log(error);
          });              
        }
      }
  }
})

Vue.component('org-chart-item', {
  props: {
    isMainNode:{
      type: Boolean,
      default: false
    },
    node: null
  },
  template: `<ul> 
              <li :key="n.id" v-for="n in node" :class="isMainNode? false: 'tnode'"> 
                <div :id="n.id" class="trcont" @click="onToogle($event, '#child-' + n.id)" 
                  draggable="true" ondragover="event.preventDefault();" 
                  @drop="drop($event)" @dragstart="drag($event)">                  
                  <slot name="content" :data="n">
                    <div class="ui-widget-header ui-corner-tl ui-corner-tr">{{ n.title }}</div>
                    <div class="ui-widget-content ui-corner-bl ui-corner-br">{{ n.description }}</div>
                  </slot>
                </div>                
                <div :id="'child-' + n.id" v-if="(n.children !== undefined && n.children !== null && n.children.length > 0)" class="trchl">
                  <org-chart-item :node="n.children"> 
                    <!-- Pass on all named slots -->
                    <slot v-for="slot in Object.keys($slots)" :name="slot" :slot="slot"/>

                    <!-- Pass on all scoped slots -->
                    <template v-for="slot in Object.keys($scopedSlots)" :slot="slot" slot-scope="scope"><slot :name="slot" v-bind="scope"/></template>                    
                  </org-chart-item>
                </div>
              </li>
             </ul>`,
  methods:{
    onToogle: function (event, target) {
      $(target).slideToggle(500);
    },
    drag: function(ev) {
      console.log(ev);
      ev.dataTransfer.setData("text", ev.target.id);
    },
    drop: function (ev) {
      console.log("drop");
      var data = ev.dataTransfer.getData("text");
      ev.target.parentElement.appendChild(document.getElementById(data));
    }
  }
})

function unflatten(array, parent, tree) {
  var tree = typeof tree !== 'undefined' ? tree : [];
  var parent = typeof parent !== 'undefined' ? parent : { id: null };
  
  var children = array.filter(function(child){ return child.parentId === parent.id; });

  if (children.length) {
    if (!parent.id) {
      tree = children;
    } else {
      parent['children'] = children;
    }
    children.forEach(function(child){ unflatten( array, child ) } );                    
  }

  return tree;
}

function list_to_tree(list) {
    var map = {}, node, roots = [], i;
    for (i = 0; i < list.length; i += 1) {
        map[list[i].id] = i; // initialize the map
        list[i].children = []; // initialize the children
    }
      
    for (i = 0; i < list.length; i += 1) {
        node = list[i];
        if (node.parentId !== "0" && node.parentId !== null) {
            // if you have dangling branches check that map[node.parentId] exists
            list[map[node.parentId]].children.push(node);
        } else if(roots !== undefined) {
            roots.push(node);
        } 
    }
    
    return roots;
}