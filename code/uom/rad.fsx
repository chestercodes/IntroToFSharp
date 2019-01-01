let pi = System.Math.PI

[<Measure>] type radian
[<Measure>] type degree

let degToRad = 2.0 * pi / 360.0<degree/radian> // float<radian/degree>
let radToDeg = 1.0 / degToRad                  // float<degree/radian>
let somethingRad = 1.493<radian>               // float<radian>
let somethingDeg = 100.0<degree>               // float<degree>
let radThing = somethingRad + somethingDeg * degToRad // float<radian>
let doesntCompile = somethingRad + somethingDeg
