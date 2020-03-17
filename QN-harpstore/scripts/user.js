var account = {} || account;
account.openModal = function() {
    account.reset();
    $('#loginModal').modal('show');
},
account.login = function(){
    if($('#formLogin').valid()){
        let email = $('#inputEmail').val();
        let pass = $('#inputPassword').val();
        let author = false;
        $.ajax({
            url:'http://localhost:3000/account',
            method : 'GET',
            dataType : 'json',
            success : function(data){
                $.each(data, function(index, value){
                    if(value.emailAddress == email && value.password == pass){
                        window.location.href = "../admin.html";
                        author = true;
                    }
                });
                if(!author){
                    $('#error-msg').addClass('show');
                }
            }
        });
    }
}
account.reset = function() {
    $('#emailAddress').val('');
    $('#password').val('');
    var validator = $("#formLogin").validate();
    validator.resetForm();
};
account.init = function(){
};

$(document).ready(function(){ 
});