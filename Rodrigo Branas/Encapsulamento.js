
////Fabric mode 
// var createCounter = function () {
//     var value = 0;
//     return {
//         add: function () {
//             return ++value;
//         }
//     };
// };



//Constructor mode 
var Counter = function(){
    var value = 0;
    this.add = function(){
        return ++value;
    }
}

// var counter = createCounter();
 var counter = new Counter();
console.log(counter.add());
console.log(counter.add());
console.log(counter.value);