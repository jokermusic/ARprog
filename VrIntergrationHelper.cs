void OnPreRender()
{
    // on pre render is where projection matrix and pixel rect 
    // are set up correctly (for each camera individually)
    // so we use this to acquire this data.
     
    if (IsLeft && !mLeftCameraDataAcquired)
    {
        if (
            !float.IsNaN(mLeftCamera.projectionMatrix[0,0]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[0,1]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[0,2]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[0,3]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[1,0]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[1,1]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[1,2]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[1,3]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[2,0]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[2,1]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[2,2]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[2,3]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[3,0]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[3,1]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[3,2]) &&
            !float.IsNaN(mLeftCamera.projectionMatrix[3,3])
           )
        {
            mLeftCameraMatrixOriginal = mLeftCamera.projectionMatrix;
            mLeftCameraPixelRect = mLeftCamera.pixelRect;
            mLeftCameraDataAcquired = true;
        }
    }
    else if (!mRightCameraDataAcquired)
    {
        if (
            !float.IsNaN(mRightCamera.projectionMatrix[0,0]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[0,1]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[0,2]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[0,3]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[1,0]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[1,1]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[1,2]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[1,3]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[2,0]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[2,1]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[2,2]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[2,3]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[3,0]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[3,1]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[3,2]) &&
            !float.IsNaN(mRightCamera.projectionMatrix[3,3])
           )
        {
            mRightCameraMatrixOriginal = mRightCamera.projectionMatrix;
            mRightCameraPixelRect = mRightCamera.pixelRect;
            mRightCameraDataAcquired = true;
        }
    }
}
