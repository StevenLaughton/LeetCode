class Startup {
  public static main(): void {
    let result = removeDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);

    console.log(result);
  }
}

function removeDuplicates(nums: number[]): number {
  for (let index = 0; index < nums.length; ) {
    if (index !== 0 && nums[index] === nums[index - 1]) {
      nums.splice(index, 1);
    } else {
      index++;
    }
  }
  return nums.length;
}

Startup.main();
