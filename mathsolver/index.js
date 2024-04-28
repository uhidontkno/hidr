 
const mathsteps = require('mathsteps');
let friendlyChangeTypes = {
    "NO_CHANGE": "doing nothing",
    "SIMPLIFY_ARITHMETIC": "simplifying the arithmetic",
    "DIVISION_BY_NEGATIVE_ONE": "dividing by negative one",
    "DIVISION_BY_ONE": "dividing by one",
    "MULTIPLY_BY_ZERO": "multiplying by zero",
    "REARRANGE_COEFF": "rearranging coefficients",
    "REDUCE_EXPONENT_BY_ZERO": "reducing the exponent by zero",
    "REDUCE_ZERO_NUMERATOR": "reducing the zero numerator",
    "REMOVE_ADDING_ZERO": "removing the adding by zero",
    "REMOVE_EXPONENT_BY_ONE": "removing the exponent by one",
    "REMOVE_EXPONENT_BASE_ONE": "removing exponent base one",
    "REMOVE_MULTIPLYING_BY_NEGATIVE_ONE": "remove the multiplying by negative one",
    "REMOVE_MULTIPLYING_BY_ONE": "remove the multiplying by one",
    "RESOLVE_DOUBLE_MINUS": "resolving double minus",
    "COLLECT_AND_COMBINE_LIKE_TERMS": "collecting and combining like terms",
    "COLLECT_LIKE_TERMS": "collecting like terms",
    "COLLECT_CONSTANT_EXPONENTS": "collecting the constant exponents",
    "ADD_COEFFICIENT_OF_ONE": "adding the coefficient of one",
    "ADD_POLYNOMIAL_TERMS": "adding the polynomial terms",
    "GROUP_COEFFICIENTS": "grouping coefficients",
    "UNARY_MINUS_TO_NEGATIVE_ONE": "doing the unary minus to negative one",
    "ADD_EXPONENT_OF_ONE": "adding the exponent of one",
    "COLLECT_POLYNOMIAL_EXPONENTS": "collecting polynomial exponents",
    "MULTIPLY_COEFFICIENTS": "multiplying coefficients",
    "MULTIPLY_POLYNOMIAL_TERMS": "multiplying polynomial terms",
    "BREAK_UP_FRACTION": "breaking up the fraction",
    "CANCEL_MINUSES": "canceling the minuses",
    "CANCEL_TERMS": "canceling terms",
    "SIMPLIFY_FRACTION": "simplifying the fraction",
    "SIMPLIFY_SIGNS": "simplifying signs",
    "FIND_GCD": "finding the greatest common divisor (GCD)",
    "CANCEL_GCD": "canceling the greatest common divisor (GCD)",
    "CONVERT_MIXED_NUMBER_TO_IMPROPER_FRACTION": "converting the mixed number to a improper fraction",
    "IMPROPER_FRACTION_NUMERATOR": "making a improper fraction numerator",
    "ADD_FRACTIONS": "adding fractions",
    "ADD_NUMERATORS": "adding numerators",
    "COMBINE_NUMERATORS": "combining numerators",
    "COMMON_DENOMINATOR": "finding the common denominator",
    "CONVERT_INTEGER_TO_FRACTION": "converting the integer to a fraction",
    "DIVIDE_FRACTION_FOR_ADDITION": "dividing the fraction for addition",
    "MULTIPLY_DENOMINATORS": "multiplying denominators",
    "MULTIPLY_NUMERATORS": "multiplying numerators",
    "MULTIPLY_FRACTIONS": "multiplying fractions",
    "SIMPLIFY_DIVISION": "simplifying division",
    "MULTIPLY_BY_INVERSE": "multiplying by inverse",
    "DISTRIBUTE": "distributing",
    "DISTRIBUTE_NEGATIVE_ONE": "distributing negative one",
    "SIMPLIFY_TERMS": "simplifying terms",
    "EXPAND_EXPONENT": "expanding the exponent",
    "ABSOLUTE_VALUE": "finding the absolute value",
    "CANCEL_EXPONENT": "canceling exponent",
    "CANCEL_EXPONENT_AND_ROOT": "canceling the exponent and root",
    "CANCEL_ROOT": "canceling root",
    "COMBINE_UNDER_ROOT": "combine under root",
    "CONVERT_MULTIPLICATION_TO_EXPONENT": "converting the multiplication to an exponent",
    "DISTRIBUTE_NTH_ROOT": "distribute nth root",
    "EVALUATE_DISTRIBUTED_NTH_ROOT": "evaluate distributed nth root",
    "FACTOR_INTO_PRIMES": "factor into primes",
    "GROUP_TERMS_BY_ROOT": "group terms by root",
    "NTH_ROOT_VALUE": "finding the nth root value",
    "ADD_NTH_ROOTS": "adding nth roots",
    "MULTIPLY_NTH_ROOTS": "multiplying nth roots",
    "ADD_TO_BOTH_SIDES": "adding to both sides",
    "DIVIDE_FROM_BOTH_SIDES": "dividing from both sides",
    "MULTIPLY_BOTH_SIDES_BY_INVERSE_FRACTION": "multiplying both sides by the inverse fraction",
    "MULTIPLY_BOTH_SIDES_BY_NEGATIVE_ONE": "multiplying both sides by negative one",
    "MULTIPLY_TO_BOTH_SIDES": "multiplying to both sides",
    "SIMPLIFY_LEFT_SIDE": "simplifying left side",
    "SIMPLIFY_RIGHT_SIDE": "simplifying right side",
    "SUBTRACT_FROM_BOTH_SIDES": "subtracting from both sides",
    "SWAP_SIDES": "swapping sides",
    "FIND_ROOTS": "finding roots",
    "STATEMENT_IS_TRUE": "statement is true",
    "STATEMENT_IS_FALSE": "statement is false",
    "FACTOR_SYMBOL": "factor symbol",
    "FACTOR_DIFFERENCE_OF_SQUARES": "factor difference of squares",
    "FACTOR_PERFECT_SQUARE": "factoring the perfect square",
    "FACTOR_SUM_PRODUCT_RULE": "factoring by the sum-product rule",
    "BREAK_UP_TERM": "breaking up the term"
  }


let problem = process.argv[3]
let steps;
if (process.argv[2] == "solve") {
    steps = mathsteps.solveEquation(problem,false);
}
else if (process.argv[2] == "simplify") {
    steps = mathsteps.simplifyExpression(problem,false)
}
else if (process.argv[2] == "factor") {
    steps = mathsteps.factor(problem,false)
} else {console.log("Invalid type.");process.exit(0)}
console.log(`Problem: ${problem}`)
// console.log(steps.length)
if (steps.length != 0) { 


let i = 0;
if (!process.argv[3] || process.argv[3] == "") {
    console.log("No problem provided.");process.exit(0)
}
if (process.argv[2] == "solve") {
    console.log(`Solution: ${steps[steps.length - 1].newEquation.ascii()}\n`)
    console.log("Steps:")
steps.forEach(step => {
    i++
    console.log(`Step ${i}:\n`);
    console.log("Turn " + step.oldEquation.ascii() + "\ninto " + step.newEquation.ascii() + "\nby " + friendlyChangeTypes[step.changeType])
    console.log()  
});
} else  {
    console.log(`Solution: ${steps[steps.length - 1].newNode.toString()}\n`)
    console.log("Steps:")
    steps.forEach(step => {
        i++
        console.log(`Step ${i}:\n`);
        console.log("Turn " + step.oldNode.toString() + "\ninto " + step.newNode.toString() + "\nby " + friendlyChangeTypes[step.changeType])
        console.log()  
    });
    }
} else {
    try {
    console.log(`Solution: ${eval(problem)}\n`)
    } catch {
        console.log("\nNo solution can be generated,")
        console.log("Could already be solved.")
    }
}
