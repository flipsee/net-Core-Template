Vue.component('nav-menu', {
  props: {    
    menus: Array,
    isMainNode:{
      type: Boolean,
      default: true
    }
  },
    template: ` <ul :class="isMainNode? 'sidebar-menu': 'treeview-menu'" :data-widget="isMainNode? 'tree': false" v-if="(menus !== undefined && menus !== null && menus.length > 0)">  
                  <nav-menu-item :key="menuItem.id" v-for="menuItem in menus" v-bind="menuItem"></nav-menu-item>
                </ul>`
})

Vue.component('nav-menu-item', {
  props: {
    id: Number,
    className: String,
    url: String,
    icon: String,
    description: String,
    badges: Array,
    children: Array
  },
  template: `<li :class="className"> 
                <a :href="url" :is="className === 'header' ? 'span' : 'a'">  
                  <i v-if="icon !== null" :class="icon"></i>
                  <span>{{ description }}</span>         
                  <span v-if="((badges !== null && badges !== undefined && badges.length > 0) || (children !== null && children !== undefined && children.length > 0))" class="pull-right-container">
                    <small v-for="badge in badges" :class="badge.className">{{ badge.text }}</small>
                    <i v-if="(children !== null && children !== undefined && children.length > 0)" class="fa fa-angle-left pull-right"></i>
                  </span>
                </a>
                <nav-menu v-bind:menus="children" :isMainNode="false"></nav-menu>                
              </li>`,
    methods: {
        /*
        _setUpListeners: function () {
            let that = this;
            $(this.element).on('click', function (event) {
                that.toggle($(this), event);
            });
        },
        toggle: function (link, event) {
            let treeviewMenu = link.next(Selector.treeviewMenu);
            let parentLi = link.parent();
            let isOpen = parentLi.hasClass(ClassName.open);

            if (!parentLi.is(Selector.treeview)) {
                return;
            }

            if (link.attr('href') === '#') {
                event.preventDefault();
            }

            if (isOpen) {
                this.collapse(treeviewMenu, parentLi);
            } else {
                this.expand(treeviewMenu, parentLi);
            }
        },
        expand: function (tree, parent) {
            let expandedEvent = $.Event(Event.expanded);

            if (this.options.accordion) {
                let openMenuLi = parent.siblings(Selector.open);
                let openTree = openMenuLi.children(Selector.treeviewMenu);
                this.collapse(openTree, openMenuLi);
            }

            parent.addClass(ClassName.open);
            tree.slideDown(this.options.animationSpeed, function () {
                $(this.element).trigger(expandedEvent);
            }.bind(this));
        },
        collapse: function (tree, parentLi) {
            let collapsedEvent = $.Event(Event.collapsed);
            parentLi.removeClass(ClassName.open);
            tree.slideUp(this.options.animationSpeed, function () {
                $(this.element).trigger(collapsedEvent);
            }.bind(this));
        }
        */
    }
})