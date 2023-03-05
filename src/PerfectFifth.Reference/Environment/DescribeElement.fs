module P5Reference.Environment.DescribeElement

open P5.Core
open P5.Shape
open P5.Environment
open P5.Color

let draw p5 =
    describe p5 "Heart and yellow circle over pink background"
    noStroke p5
    background p5 (Name "pink")

    describeElement p5 "Circle" "Yellow circle in the top left corner"
    fill p5 (Name "yellow")
    circle p5 25 25 40

    // Use describeElementWithDisplay to pass a display mode as well:
    // describeElementWithDisplay p5 "Some text" Fallback
    describeElement p5 "Heart" "Red heart in the bottom right corner"
    fill p5 (Name "red")
    ellipse p5 66.6 66.6 20 20
    ellipse p5 83.2 66.6 20 20
    triangle p5 91.2 72.6 75 95 58.6 72.6

let run node = display node draw
