function procura(texto) {
    let contador = 0;
    const letras = texto.split('');

    for (let i = 0; i < letras.length; i++) {
        if (letras[i] === 'A' || letras[i] === 'a') {
            contador++;
        }
    }

    console.log(contador);
}