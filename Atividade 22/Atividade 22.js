function ordena(num1, num2, num3, num4, num5) {
    const numeros = [num1, num2, num3, num4, num5];
    numeros.sort((a, b) => b - a);
    console.log(numeros);
}