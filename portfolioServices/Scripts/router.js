var AppRouter = Backbone.Router.extend({
    routes: {
        "portfolio/:id/token/:token": "showUser",
        "portfolio/:id": "showStock",
        "" : "showDefaultStock"
    },

    showDefaultStock: function()
    {      
      this.showStock('msft');
    },

    showStock: function (stockid) {
        var stock = new Stock({ id: stockid });
        var stockView = new StockView({ model: stock });        
        $("#stockQuote").html(stockView.el);
        stock.fetch();
    },
    
    showUser: function (userId, token) {
        var userModel = new UserModel({id: userId, token: token});
        var userView = new UserView({model: userModel});
        $("#userInfo").html(userView.el);
        userModel.fetch();        
    }

});

var app_router = new AppRouter;
Backbone.history.start();

