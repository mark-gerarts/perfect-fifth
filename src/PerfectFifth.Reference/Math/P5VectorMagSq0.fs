module P5Reference.Math.P5VectorMagSq0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (6, 4, 2)
    print p5 (string <| v1.magSq ()) // Prints "56"

let run node = display node draw
