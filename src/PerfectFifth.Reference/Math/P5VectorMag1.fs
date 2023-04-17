module P5Reference.Math.P5VectorMag1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (20.0, 30.0, 40.0)
    let m = v.mag ()
    print p5 (string m) // Prints "53.85164807134504"

let run node = display node draw
