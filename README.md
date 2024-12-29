This repository demonstrates a common error in F# when working with mutable variables within function parameters.  The provided `swap` function attempts to swap the values of two mutable variables, but fails to do so correctly due to how F# handles mutable parameters. The solution illustrates the proper approach using tuples or reference cells.