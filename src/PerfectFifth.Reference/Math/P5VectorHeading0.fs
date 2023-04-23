module P5Reference.Math.P5VectorHeading0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (30, 50)
    print p5 (v1.heading () |> string) // 1.0303768265243125

    let v2 = P5Vector.create (40, 50)
    print p5 (v2.heading () |> string) // 0.8960553845713439

    let v3 = P5Vector.create (30, 70)
    print p5 (v3.heading () |> string) // 1.1659045405098132

let run node = display node draw
