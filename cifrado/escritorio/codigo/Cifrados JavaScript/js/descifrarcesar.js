var descifrarCesar = function(salida, desplazamiento){
    desplazamiento = parseInt(desplazamiento);
    var alfabeto = 'abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789';
        resultado = '';

    for(var i=0, caracter; caracter=salida[i]; i++){
        var caracter_descifrado = '',
            indice_actual = alfabeto.indexOf( caracter );

        if((indice_actual - desplazamiento) >= 0){
            caracter_descifrado = alfabeto[ (indice_actual - desplazamiento) ];
            resultado += caracter_descifrado;
        }
        else{
            var indice_actual_temporal = indice_actual - desplazamiento;
                sobrante = indice_actual_temporal;
            caracter_descifrado = alfabeto[alfabeto.length + sobrante];
            resultado += caracter_descifrado;
        }
    }

    return resultado;
}