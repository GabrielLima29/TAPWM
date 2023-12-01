function dividir(a, b) {
    if (isNaN(a) || isNaN(b)) {
        return "Divisao deu NaN";
    }

    if (!isFinite(a) || !isFinite(b)) {
        return "Divisao de Infinity";
    }

    if (a === 0 && b === 0) {
        return "Divisao invalida -> NaN";
    }

    if (a === 0) {
        return "Divisao invalida -> 0";
    }

    if (b === 0) {
        return "Divisao invalida -> Infinity";
    }

    return a / b;
}

console.log(dividir(4, 2)); // Retorna 2
console.log(dividir(4, 0)); // Retorna "Divisao invalida -> Infinity"
console.log(dividir(0, 0)); // Retorna "Divisao invalida -> NaN"
console.log(dividir(null, 2)); // Retorna "Divisao invalida -> 0"
console.log(dividir(4, null)); // Retorna "Divisao invalida -> Infinity"
console.log(dividir(null, null)); // Retorna "Divisao invalida -> NaN"