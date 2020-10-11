var Startup = /** @class */ (function () {
    function Startup() {
    }
    Startup.main = function () {
        var result = removeDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
        console.log(result);
    };
    return Startup;
}());
function removeDuplicates(nums) {
    for (var index = 0; index < nums.length;) {
        if (index !== 0 && nums[index] === nums[index - 1]) {
            nums.splice(index, 1);
        }
        else {
            index++;
        }
    }
    return nums.length;
}
Startup.main();
//# sourceMappingURL=Main.js.map