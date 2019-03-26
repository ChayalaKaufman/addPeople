$(() => {
   let counter = 0;

    $("#add").on('click', function () {
        $("#form").append(`<input type="text" placeholder="First Name" name="ppl[${counter}].FirstName" class="form-control" />
        <br />
        <input type="text" placeholder="Last Name" name="ppl[${counter}].LastName" class="form-control" />
        <br />
        <input type="text" placeholder="Age" name="ppl[${counter}].Age" class="form-control" />
        <br />`);

        counter++;
    });
});