/**
 * @param {string} s
 * @return {string}
 */
var makeFancyString = function(s) {
    const arr = [];
    for (let i in s) {
        if (arr.length < 2 || arr[arr.length - 2] != arr[arr.length - 1] || arr[arr.length - 1] != s[i]) arr.push(s[i]);
    }
    return arr.join("");
};