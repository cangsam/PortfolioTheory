var StockListView = Backbone.View.extend({
    initialize: function () {
        this.collection.on('reset', this.addAll, this);
        this.collection.on('add', this.addOne, this);        
    },
    addOne: function (stock) {
        var stockView = new StockView({ model: stock });
        this.$el.append(stockView.render().el);
    },
    addAll: function () {
        this.collection.forEach(this.addOne, this);
    },
    render: function () {
        addAll();
    }

});