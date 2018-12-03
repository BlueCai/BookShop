var pageTab = {
    addPage: function (title, url, id) {
        //新增一个Tab项
        element.tabAdd('page_tab', {
            title: title,
            content: '<iframe tab-id="' + id + '" frameborder="0" src="' + url + '" scrolling="yes" class="x-iframe"></iframe>',
            id: id
        });
    },
    removePage: function (othis) {
        //删除指定Tab项
        element.tabDelete('page_tab', '44'); //删除：“商品管理”
        othis.addClass('layui-btn-disabled');
    },
    switchPage: function (id) {
        //切换到指定Tab项
        element.tabChange('page_tab', id); //切换到：用户管理
    }
}