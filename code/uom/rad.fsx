[<Measure>] type radian
[<Measure>] type degree

let degToRadians = 2.0 * System.Math.PI / 360.0<degree/radian>
let radToDeg = (1.0 / degToRadians)
let somethingRad = 1.493<radian>
let somethingDeg = 100.0<degree>
let radThing = somethingRad + somethingDeg * degToRadians

let res = radToDeg * 1.0<radian>
