$(function () {
    $('#btnSubmit').click(function () {
        //Retrive the number from the text box
        var number = $('#txtNumber').val();

        //Check if the number is divided by 2
        var result = number % 2;

        if (result == 0) {
            alert('Number is even');
        }
        else {
            alert('Number is odd');
        }
    });
});