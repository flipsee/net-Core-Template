$(document).ready(InitPage);

function InitPage(e) {
    try {
        //Resolve conflict in jQuery UI tooltip with Bootstrap tooltip
        //$.widget.bridge('uibutton', $.ui.button);

        $('.modal-popup').unbind("click").on('click', function (e) {
            e.preventDefault(); 
            var element = $(this);
            Site.ShowModal(element); 
        });
        
    } catch (ex) { console.log(ex); }
}

class SiteJS {
    constructor() { 
        this.myModalName = "myModal";
        this.baseUrl = $('head base').attr('href');
        this.modalType = Object.freeze({
            default: "",
            success: "success",
            warning: "warning",
            confirmation: "primary",
            error: "danger",
            info: "info"
        });
    }
}

var Site = new SiteJS();

Site.ResolveUrl = function (url) {
    return url.replace("~/", this.baseUrl);
}

Site.GetHref = function (element) {
    if ($(element['data-href']).length > 0) {
        return Site.ResolveUrl(element.data('href'));
    } else {
        return Site.ResolveUrl(element.attr('href'));
    }
}

Site.ShowModal = function (element) {    
    Site._showModal(Site.modalType.default, null, null, null, null, Site.GetHref(element)); 
}

Site.ShowSuccess = function (title, message, OnOkClickFunction) {
    Site._showModal(Site.modalType.success, title, message, OnOkClickFunction);
};

Site.ShowInfo = function (title, message, OnOkClickFunction) {
    Site._showModal(Site.modalType.info, title, message, OnOkClickFunction);
};

Site.ShowError = function (title, message, OnOkClickFunction) {
    Site._showModal(Site.modalType.error, title, message, OnOkClickFunction);
};

Site.ShowWarning = function (title, message, OnOkClickFunction) {
    Site._showModal(Site.modalType.warning, title, message, OnOkClickFunction);
};

Site.ShowConfirmation = function (title, message, OnOkClickFunction, OnCancelClickFunction) {
    Site._showModal(Site.modalType.confirmation, title, message, OnOkClickFunction, OnCancelClickFunction);
}

Site.CloseModal = function () { 
    $('#' + this.myModalName).modal('hide');  
    $(".modal-backdrop").remove();
}

Site._showModal = function (modalType, title, message, rOkOnClickFunction, rCancelOnClickFunction, url) {    
    let template = '<div class="modal-content"> \
                        <div class="modal-header">  \
                            <button class="close" aria-label="Close" type="button" data-dismiss="modal">    \
                                <span aria-hidden="true">&times;</span> \
                            </button>   \
                            <h5 class="modal-title" id="myModalLabel"></h5> \
                        </div>  \
                        <div class="modal-body"></div>  \
                        <div class="modal-footer"></div> \
                    </div>';
    
    let myModal = $('#' + this.myModalName);
    myModal.find('.modal-dialog').html(template);     
    myModal.removeClass(function (index, className) {
        return (className.match(/(^|\s)modal-\S+/g) || []).join(' ');
    });
    /*myModal.removeClass();    
    $(".modal").unbind("shown.bs.modal");
    $(".modal").unbind("hidden.bs.modal");
    myModal.addClass("modal");
    myModal.addClass("fade");
    
    $(".modal").unbind("shown.bs.modal").on("shown.bs.modal", function () {
        if ($(".modal-backdrop").length > 1) {
            $(".modal-backdrop").not(':first').remove();
        }
    })
    $(".modal").unbind("hidden.bs.modal").on("hidden.bs.modal", function () {
        $(".modal-backdrop").remove();
    })
    */
    let buttonClass = "btn-default";
    if (modalType !== "") {
        myModal.addClass("modal-" + modalType);
        buttonClass = "btn-" + modalType;
    }   

    if ((url !== undefined && url !== null && url !=="") || (message !== undefined && message !== null && message !=="")) {
        if (url !== undefined && url !== null && url !=="") { 
            myModal.find('.modal-dialog').load(url); 
        } else {                       
            myModal.find('.modal-title').text(title);
            myModal.find('.modal-body').text(message);
            if ($.isFunction(rOkOnClickFunction)) {
                myModal.find('.modal-footer').html('<button class="btn ' + buttonClass + '" id="rOkOnClickFunction">Ok</button>');
                $("#rOkOnClickFunction").on("click", function () {
                    rOkOnClickFunction.apply();
                });                
            }
            if ($.isFunction(rCancelOnClickFunction)) {
                myModal.find('.modal-footer').html('<button class="btn ' + buttonClass + '" id="rCancelOnClickFunction">Cancel</button>');
                $("#rCancelOnClickFunction").on("click", function () {
                    rCancelOnClickFunction.apply();
                });
            }
            
        }     
        myModal.modal('show');          
    }
};

var vue = new Vue({
    el: '#app',
    data: { 
        navMenu: []
    },
    created: function () { 
        this.loadData();
    },
    mounted() {
        /*
        var Default = {
            animationSpeed: 200,
            accordion: true,
            followLink: false,
            trigger: '.treeview a'
        }; 
        $('.sidebar-menu').tree(Default);
        */
    },
    methods: {
        loadData: function () {
            let self = this; 
            $.ajax({
                url: Site.baseUrl + 'api/menu',
                method: 'GET',
                success: function (data) {
                    console.log(data);
                    self.navMenu = data;                    
                },
                error: function (error) {
                    console.log(error);
                }
            });
        },
        bindmenu: function () {
            this.loadData();
            $('ul').tree({
                animationSpeed: 200
            });
        }

    }
})