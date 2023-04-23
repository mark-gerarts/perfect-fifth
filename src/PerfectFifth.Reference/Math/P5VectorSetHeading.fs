module P5Reference.Math.P5VectorSetHeading

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (10.0, 20.0)
    // result of v.heading() is 1.1071487177940904
    print p5 (v.heading () |> string)

    v.setHeading pi
    // result of v.heading() is now 3.141592653589793
    print p5 (v.heading () |> string)

let run node = display node draw
