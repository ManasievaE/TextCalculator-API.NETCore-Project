﻿
document.getElementById("calculator-form").addEventListener("submit", async function (event) {
    event.preventDefault();
    const numbers = event.target.elements.numbers.value;

    try {
        const response = await fetch(`https://localhost:44313/api/TextCalculator?input=` + numbers, {
            method: "POST",
            headers: {
                "content-type": "application/json"
            },
            //body: JSON.stringify({ input: numbers })
        });


        if (!response.ok) {
            throw new error(response.statustext);
       }

        const result = await response.text();
        document.getElementById("result").innerHTML = result;
    }  catch (error) {
        document.getElementById("result").innerHTML = error.message;
    }
});