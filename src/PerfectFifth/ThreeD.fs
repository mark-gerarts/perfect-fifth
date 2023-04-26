namespace P5

module ThreeD =

    open Fable.Core
    open Fable.Core.JsInterop
    open P5.Core
    open Color
    open Math

    type P5Camera =
        [<Emit("$0.pan($1)")>]
        member _.pan(angle: float) : Unit = jsNative

        [<Emit("$0.tilt($1)")>]
        member _.tilt(angle: float) : Unit = jsNative

    [<Emit("$0.createCamera()")>]
    let createCamera (p5: P5) : P5Camera = jsNative

    [<Emit("$0.orbitControl()")>]
    let orbitControl (p5: P5) : Unit = jsNative

    [<Emit("$0.orbitControl($1, $2, $3)")>]
    let orbitControlWithSensitivity (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

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

    [<Emit("$0.debugMode()")>]
    let debugMode (p5: P5) : Unit = jsNative

    let debugModeGrid (p5: P5) : Unit =
        let p5' = unbox<obj> p5
        let grid = p5'?("GRID")

        emitJsExpr (p5, grid) "$0.debugMode($1)"

    type GridOptions =
        { gridSize: float
          gridDivisions: float
          xOff: float
          yOff: float
          zOff: float }

    let debugModeGridWithOptions (p5: P5) (options: GridOptions) : Unit =
        let p5' = unbox<obj> p5
        let grid = p5'?("GRID")

        emitJsExpr
            (p5, grid, options.gridSize, options.gridDivisions, options.xOff, options.yOff, options.zOff)
            "$0.debugMode($1, $2, $3, $4, $5, $6)"

    let debugModeAxes (p5: P5) : Unit =
        let p5' = unbox<obj> p5
        let axes = p5'?("AXES")

        emitJsExpr (p5, axes) "$0.debugMode($1)"

    type AxesOptions =
        { axesSize: float
          xOff: float
          yOff: float
          zOff: float }

    let debugModeAxesWithOptions (p5: P5) (options: AxesOptions) : Unit =
        let p5' = unbox<obj> p5
        let axes = p5'?("AXES")

        emitJsExpr
            (p5, axes, options.axesSize, options.xOff, options.yOff, options.zOff)
            "$0.debugMode($1, $2, $3, $4, $5)"

    let debugModeAll (p5: P5) (gridOpts: GridOptions) (axesOpts: AxesOptions) : Unit =
        emitJsExpr
            (p5,
             gridOpts.gridSize,
             gridOpts.gridDivisions,
             gridOpts.xOff,
             gridOpts.yOff,
             gridOpts.zOff,
             axesOpts.axesSize,
             axesOpts.xOff,
             axesOpts.yOff,
             axesOpts.zOff)
            "$0.debugMode($1, $2, $3, $4, $5, $6, $7, $8, $9)"

    [<Emit("$0.noDebugMode($1)")>]
    let noDebugMode (p5: P5) : Unit = jsNative

    [<Emit("$0.camera($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
    let camera
        (p5: P5)
        (x: float)
        (y: float)
        (z: float)
        (centerX: float)
        (centerY: float)
        (centerZ: float)
        (upX: float)
        (upY: float)
        (upZ: float)
        : Unit =
        jsNative
