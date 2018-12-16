var cifrarCesar = function(entrada, desplazamiento){
    var alfabeto = 'abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789';
    var resultado = '';
    desplazamiento = Number(desplazamiento);

    for(var i=0; i<entrada.length; i++){
        var caracter_cifrado = '';
            indice_actual = alfabeto.indexOf( entrada[i] );
            var residuo = desplazamiento % alfabeto.length;
            if((indice_actual+residuo) < alfabeto.length){
                caracter_cifrado = alfabeto[ (indice_actual + residuo) ];
                resultado += caracter_cifrado;
            }
        else{
             var indice_actual_temporal = indice_actual + residuo;
                sobrante = indice_actual_temporal - alfabeto.length;
             caracter_cifrado = alfabeto[sobrante];
             resultado += caracter_cifrado;
        }
    }

    return resultado.replace(/\-$/, '');
}
