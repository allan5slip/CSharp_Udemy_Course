var helloWorld = function()
{
    var message = "HelloWorld";
    return function()
    {
        return message;
    };
};

var fnHelloWorld = helloWorld();


console.log(fnHelloWorld());