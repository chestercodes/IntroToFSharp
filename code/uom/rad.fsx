let pi = System.Math.PI

[<Measure>] type radian
[<Measure>] type degree
let degToRad = (2.0 * pi / 360.0) * 1.0<radian/degree> // float<radian/degree>

let twoRad = 2.0<radian>              // float<radian>
let oneHundredDeg = 100.0<degree>     // float<degree>
let twoRadsPlus100Degrees = 
    twoRad + oneHundredDeg * degToRad // float<radian>
let doesntCompile = twoRad + oneHundredDeg
