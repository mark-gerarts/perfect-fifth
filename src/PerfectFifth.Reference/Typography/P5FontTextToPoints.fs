module P5Reference.Typography.P5FontTextToPoints

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography
open P5.Rendering
open P5.Transform

let preload p5 = loadFont p5 "assets/inconsolata.otf"

let setup p5 (font: P5Font) =
    createCanvas p5 100 100
    stroke p5 (Grayscale 0)
    fill p5 (RGB(255, 104, 204))

    let ttpOpts =
        { sampleFactor = 5
          simplifyTreshold = 0 }

    let points = font.textToPointsWithOptions "p5" 0 0 10 ttpOpts
    let bounds = font.textBoundsWithSize " p5 " 0 0 10

    (points, bounds)

let draw p5 (points: TextPoint array, bounds: BoundingBox) =
    let width = width p5 |> float
    let height = height p5 |> float
    let seconds = (millis p5 |> float) / 1000.0

    background p5 (Grayscale 255)
    beginShape p5
    translate p5 (-bounds.x * width / bounds.w) (-bounds.y * height / bounds.h)

    let drawVertex p =
        vertex
            p5
            (p.x * width / bounds.w + sin (20.0 * p.y / bounds.h + seconds) * width / 30.0)
            (p.y * height / bounds.h)

    Array.iter drawVertex points

    endShapeAndClose p5

let run node =
    simulateWithPreload node preload setup noUpdate draw
