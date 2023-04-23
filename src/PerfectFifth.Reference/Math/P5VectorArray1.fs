module P5Reference.Math.P5VectorArray1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (10.0, 20.0, 30.0)
    let f = P5Vector.array (v)
    print p5 (string f[0]) // Prints "10.0"
    print p5 (string f[1]) // Prints "20.0"
    print p5 (string f[2]) // Prints "30.0"

let run node = display node draw
