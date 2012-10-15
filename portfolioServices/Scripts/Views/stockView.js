var StockView = Backbone.View.extend({
    tagName: 'tr',
    initialize: function () {
        this.model.on('change', this.render, this);
        this.model.on('hide', this.remove, this);
    },
    remove: function(){
        this.$el.remove();
    },
    render: function () {
        //var html = '<h3>id:' + this.model.id + ' symbol:' + this.model.symbol + ' price:' + this.model.price + '</h3>';
        var html = '<td>symbol:' + this.model.get('symbol') + '</td><td>price:' + this.model.get('price') + '</td>';
        //$('#stockQuote').html(html);
        this.$el.html(html);
        return this;
    }
});