module P5Examples.Structure.Animate

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let setup p5 = createCanvas p5 100 100

let draw p5 t =
    background p5 (Grayscale 0)

    // Grow between radius 50 and 100 based on time passed.
    let size = 50 + ((t / 100) % 50)
    circle p5 50 50 size

let run node = animate node setup draw
