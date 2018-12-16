    var cifrarInversoGrupo = function(entrada,tamañogrupo){
        var resultado = '';
        tamañogrupo = parseInt(tamañogrupo);
        var pares = entrada/tamañogrupo;
        var grupocreado = 0,caractergrupo = '',parescreados = 0;

        for(var i=0; i<entrada.length; i++){

            var caracter_cifrado = entrada[i];
                caractergrupo += caracter_cifrado;
                grupocreado ++;
                if(grupocreado == tamañogrupo && parescreados <= pares)
                {
                    for(var j=tamañogrupo-1; j >= 0; j--){
                    resultado += caractergrupo[j];
                    }
                    caractergrupo = '';
                    parescreados ++;
                }
                
        }
        return resultado + caractergrupo;
    }

/*
    for(var i=entrada.length-1; i >= 0; i--){
        for(var grupo=entrada.length; grupo>=0; grupo+tamañogrupo){
            var caracter_cifrado = entrada[i];
            resultado += caracter_cifrado;
        }
    }*/