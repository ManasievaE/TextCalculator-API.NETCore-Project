
document.getElementById("calculator-form").addEventListener("submit", async function (event) {
    event.preventDefault();
    const numbers = event.target.elements.numbers.value;

    try {
        const response = await fetch(`http://localhost:44313/api/TextCalculator?input=${numbers}`);

        if (!response.ok) {
            throw new Error(response.statusText);
        }

        const result = await response.text();
        document.getElementById("result").innerHTML = result;
    } catch (error) {
        document.getElementById("result").innerHTML = error.message;
    }
});

