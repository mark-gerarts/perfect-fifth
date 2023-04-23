module P5Reference.Math.P5VectorDot1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    //Static method
    let v1 = P5Vector.create (1, 2, 3)
    let v2 = P5Vector.create (3, 2, 1)
    print p5 (P5Vector.dot (v1, v2) |> string) // Prints "10"

let run node = display node draw
