function sayHello(){
  var num=666;
  var say = function() {console.log(num);};
  num++;
  return say;
}
var say2=sayHello();
say2();
say2();
say2();
