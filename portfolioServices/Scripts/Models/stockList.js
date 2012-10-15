var StockList = Backbone.Collection.extend({
    initialize: function (models, options) {
        this.id = options.id;
        this.on('remove', this.hideModel);
    },
    hideModel: function(stock) {
        stock.trigger('hide');
    },
    model: Stock,
    url: function () {
        return '/user/' + this.id + '/stocks';
    }
    //url: function () { return '/user/5/stocks'; }    
});