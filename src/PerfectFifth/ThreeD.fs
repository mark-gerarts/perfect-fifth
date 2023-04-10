namespace P5

module ThreeD =

    open Fable.Core
    open P5.Core
    open Color
    open Math

    /// TODO: sensitivity
    [<Emit("$0.orbitControl()")>]
    let orbitControl (p5: P5) : Unit = jsNative

    [<Emit("$0.normalMaterial()")>]
    let normalMaterial (p5: P5) : Unit = jsNative

    [<Emit("$0.directionalLight($1, $2, $3, $4)")>]
    let private directionalLight_ (p5: P5) (color: P5Color) (x: float) (y: float) (z: float) : Unit = jsNative

    /// TODO: other variants
    let directionalLight (p5: P5) (c: Color) (x: float) (y: float) (z: float) : Unit =
        directionalLight_ p5 (ensureP5Color p5 c) x y z

    [<Emit("$0.pointLight($1, $2, $3, $4)")>]
    let private pointLight_ (p5: P5) (color: P5Color) (x: float) (y: float) (z: float) : Unit = jsNative

    /// TODO: other variants
    let pointLight (p5: P5) (c: Color) (x: float) (y: float) (z: float) : Unit =
        pointLight_ p5 (ensureP5Color p5 c) x y z

    [<Emit("$0.pointLight($1, $2)")>]
    let private pointLightFromVector_ (p5: P5) (color: P5Color) (v: P5Vector) : Unit = jsNative

    let pointLightFromVector (p5: P5) (c: Color) (v: P5Vector) : Unit =
        pointLightFromVector_ p5 (ensureP5Color p5 c) v

    let specularMaterial (p5: P5) (c: Color) =
        emitColorFunction p5 "specularMaterial" c
