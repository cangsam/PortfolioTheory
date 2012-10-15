var UserModel = Backbone.Model.extend({
    //urlRoot: 'http://localhost:49630/user' + this.id //,    
    url: function () { return '/user/' + this.id + '/token/' + this.attributes.token; }
});