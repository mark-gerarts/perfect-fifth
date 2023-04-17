module P5Reference.Math.P5VectorDiv3

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = P5Vector.create (9, 4, 2)
    let v1 = P5Vector.create (3, 2, 4)
    let result = P5Vector.div (v0, v1)
    print p5 (string result)

let run node = display node draw
