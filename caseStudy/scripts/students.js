var student = {} || student;

student.drawTable = function() {
    $.ajax({
        url:"http://localhost:3000/students",
        method:"get",
        datatype:"JSON",
        success :function(data) {
            $.each(data,function(i,v){
                $('#tbStudents').append(
                    "<tr>"+
                    "<td>"+v.id+"</td>"+
                    "<td>"+v.fullName+"</td>"+
                    "<td>"+v.gender+"</td>"+
                    "<td>"+v.dob+"</td>"+
                    "<td>"+
                            // "<a href='javascript:void(0);' class='btn btn-warning'>Edit</a> " +
                            // "<a href='javascript:void(0);' class='btn btn-danger'>Remove</a> " +
                            "<a href='javascript:void(0);' title='edit student'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:void(0);' title='remove student'><i class='fa fa-trash'></i></a> " +
                            "<a href='javascript:void(0);' title='send email notify'><i class='fa fa-envelope'></i></a> " +
                            "<a href='javascript:void(0);' title='block student'><i class='fa fa-ban'></i></a> " +
                    "</td>" +
                    "</tr>"
                );
            });
        }
    });
}
student.save = function(){
   if ($('#formAddEditStudent').valid()) {
       var studentObj = {};
            studentObj.fullName=$('#FullName').val();
            studentObj.gender=$('#Gender').val();
            studentObj.dob=$('#DOB').val();
            
            $.ajax({
                url:"http://localhost:3000/students",
                method:"POST",
                datatype:"JSON",
                contentType: "application/json",
                data:JSON.stringify(studentObj),
                success : function(data){
                    $('#addEditStudents').modal('hide');
                    student.drawTable();
                }
            })
   }
};
student.openModal = function(){
    $('#addEditStudents').modal('show')
};
student.init = function() {
    student.drawTable();
};
$(document).ready(function(){
    student.init();
});