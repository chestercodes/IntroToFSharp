[<Measure>] type radian
[<Measure>] type degree

let twoRad = 2.0<radian>              // float<radian>
let oneHundredDeg = 100.0<degree>     // float<degree>

let pi = System.Math.PI

// float<radian/degree>
let degToRad = (2.0 * pi / 360.0) * 1.0<radian/degree>

 // float<radian>
let twoRadsPlus100Degrees = twoRad + oneHundredDeg * degToRad

let doesntCompile = twoRad + oneHundredDeg
