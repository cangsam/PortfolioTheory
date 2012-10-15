var UserView = Backbone.View.extend({

    initialize: function () {
        this.model.on('change', this.render, this);
    },

    template: _.template($("#search_template").html()),

    render: function () {

        //var html = this.template({ id: this.model.id, username: this.model.get('username') });
        var html = this.template(this.model.toJSON());
        this.$el.html(html);
        var stockHistoryArray = this.model.get('stockHistory');


        for (var i = 0; i < stockHistoryArray.length; i++) {
            html = "<tr><td>" + stockHistoryArray[i].symbol + "</td></tr>";
            $('#stockHistoryTable > tbody:last').append(html);
        }

        return this;
    }
});