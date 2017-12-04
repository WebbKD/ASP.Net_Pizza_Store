$(document).ready(function () {

    $('.slider').slider();
    $(".button-collapse").sideNav();
    $('select').material_select();

    var pizzaCounter = 1;
    var pizzaIndex = 0;

    $(document.body).on('change','.size' ,function () {
       
        var alt = $(this).attr('alt');
        $('#size' +''+alt+'').val($(this).val());
    });

    $(document).on('change', '.topping', function () {
       // alert($(this).val());
       
    });


    $('#pizzaForm')
        .on('click', '#addButton', function () {

            pizzaCounter +=1;
            pizzaIndex +=1;
            
            var $template = $('#pizzaSelectTemplate'),
            $clone = $template
                        .clone()
                        .removeClass('hide')
                        .removeAttr('id')
                        .insertBefore($template);
            $clone
            .find('[name="sizeTemplate"]').attr('id', 'size' + pizzaIndex + '').end()
            .find('[name="sizeTemplate"]').attr('name', 'size[' + pizzaIndex + ']').end()
            .find('[class="sizeTemplate"]').attr('alt', pizzaIndex).end()
            .find('[class="sizeTemplate"]').attr('class', 'size').end()
            .find('[name="pepperoniTemplate"]').attr('name', 'pepperoni[' + pizzaIndex + ']').end()
            .find('[name="mushroomsTemplate"]').attr('name', 'mushrooms[' + pizzaIndex + ']').end()
            .find('[name="onionsTemplate"]').attr('name', 'onions[' + pizzaIndex + ']').end()
            .find('[name="sasusageTemplate"]').attr('name', 'sasusage[' + pizzaIndex + ']').end()
            .find('[name="baconTemplate"]').attr('name', 'bacon[' + pizzaIndex + ']').end()
            .find('[name="extracheeseTemplate"]').attr('name', 'extraCheese[' + pizzaIndex + ']').end()
            .find('[name="blackOlivesTemplate"]').attr('name', 'blackOlives[' + pizzaIndex + ']').end()
            .find('[name="spinachTemplate"]').attr('name', 'spinach[' + pizzaIndex + ']').end()
            .find('[name="pineappleTemplate"]').attr('name', 'pineapple[' + pizzaIndex + ']').end()



        document.getElementById('amountOfPizza').value = pizzaCounter;
        });

    

});

