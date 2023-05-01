module P5Reference.ThreeD.SpecularColor

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events

let setup p5 =
    createWebGLCanvas p5 100 100
    noStroke p5
    true

let draw p5 setRedSpecularColor =
    background p5 (Grayscale 0)
    ambientLight p5 (Grayscale 60)

    let width = width p5 |> float
    let height = height p5 |> float

    let lightPosX = mouseX p5 - width / 2.0
    let lightPosY = mouseY p5 - height / 2.0

    // -- set the light's specular color
    if setRedSpecularColor then
        do specularColor p5 (RGB(255, 0, 0)) // red specular highlight

    // -- create the light
    pointLight p5 (Grayscale 200) lightPosX lightPosY 50 // white light

    // use specular material with high shininess
    specularMaterial p5 (Grayscale 150)
    shininess p5 50

    sphereWithDetail p5 30 64 64

let toggleColor p5 _ setRedSpecularColor = not setRedSpecularColor

let subscriptions = [ OnMouseClicked(Update toggleColor) ]

let run node =
    play node setup noUpdate draw subscriptions
