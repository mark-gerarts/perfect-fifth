module P5Examples.Structure.Coordinates

open P5.Core
open P5.Color
open P5.Rendering

let setup (p5: P5) = createCanvas p5 720 400

let draw p5 = background p5 (Grayscale 0)

let sketch: Sketch<Unit> = display setup draw
