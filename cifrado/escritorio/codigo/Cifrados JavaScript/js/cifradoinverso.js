var cifrarInverso = function(entrada){
    var resultado = '';
    for(var i=entrada.length-1; i >= 0; i--){
        var caracter_cifrado = entrada[i];
        resultado += caracter_cifrado;
    }
    return resultado;

}