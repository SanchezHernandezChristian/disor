function validanumeros(tPulsada){
    tecla = (document.all) ? tPulsada.keyCode : tPulsada.which;
    if (tecla==8){
        return true;
    }
    patron =/[0-9]/;
    teclaValidada = String.fromCharCode(tecla);
    return patron.test(teclaValidada);
}