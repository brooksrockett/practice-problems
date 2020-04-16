function processData(input) {
    //Enter your code here
    arr = input.split('\n')
    phoneBook = {}
    for (let i = 1;i<=arr[0];i++) {
        let phone = arr[i].split(' ')
        let name = phone[0]
        let number = phone[1]
        phoneBook[name] = number
    }
    for (let i = (Number(arr[0])+1);i<arr.length;i++) {
        if (arr[i] in phoneBook) {
            console.log(arr[i] + '=' + phoneBook[arr[i]])
        }
        else console.log('Not found')
    }
} 
