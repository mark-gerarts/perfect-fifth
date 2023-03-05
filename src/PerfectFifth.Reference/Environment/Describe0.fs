module P5Reference.Environment.Describe0

open P5.Core
open P5.Shape
open P5.Environment
open P5.Color

let draw p5 =
    background p5 (Name "pink")
    fill p5 (Name "red")
    noStroke p5

    ellipse p5 67 67 20 20
    ellipse p5 83 67 20 20
    triangle p5 91 73 75 95 59 73

    // Use describeWithDisplay to pass a display mode as well:
    // describeWithDisplay p5 "Some text" Fallback
    describe p5 "pink square with red heart in the bottom right corner"

let run node = display node draw
