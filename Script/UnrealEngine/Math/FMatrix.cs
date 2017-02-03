using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial struct FMatrix
    {
        public readonly static FMatrix Identity = new FMatrix(EForceInit.ForceInit);

        public FMatrix(EForceInit Init) 
        {
            XPlane = new FPlane();
            YPlane = new FPlane();
            ZPlane = new FPlane();
            WPlane = new FPlane();
            SetIdentity(); 
        }

        public FMatrix(FPlane InX, FPlane InY, FPlane InZ, FPlane InW)
        {
            XPlane = InX;
            YPlane = InY;
            ZPlane = InZ;
            WPlane = InW;
        }

        public FMatrix(FVector InX, FVector InY, FVector InZ, FVector InW)
        {
            XPlane = new FPlane();
            YPlane = new FPlane();
            ZPlane = new FPlane();
            WPlane = new FPlane();

            this[0, 0] = InX.X; this[0, 1] = InX.Y; this[0, 2] = InX.Z; this[0, 3] = 0.0f;
            this[1, 0] = InY.X; this[1, 1] = InY.Y; this[1, 2] = InY.Z; this[1, 3] = 0.0f;
            this[2, 0] = InZ.X; this[2, 1] = InZ.Y; this[2, 2] = InZ.Z; this[2, 3] = 0.0f;
            this[3, 0] = InW.X; this[3, 1] = InW.Y; this[3, 2] = InW.Z; this[3, 3] = 1.0f;
        }

        public float this[int Index1,int Index2]
        {
            get
            {
                switch(Index1)
                {
                    case 0:
                        return XPlane[Index2];
                    case 1:
                        return YPlane[Index2];
                    case 2:
                        return ZPlane[Index2];
                    case 3:
                        return WPlane[Index2];
                    default:
                        throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch (Index1)
                {
                    case 0:
                        XPlane[Index2] = value;
                        break;
                    case 1:
                        YPlane[Index2] = value;
                        break;
                    case 2:
                        ZPlane[Index2] = value;
                        break;
                    case 3:
                        WPlane[Index2] = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        // Set this to the identity matrix
        public void SetIdentity()
        {
            this[0, 0] = 1; this[0, 1] = 0; this[0, 2] = 0; this[0, 3] = 0.0f;
            this[1, 0] = 0; this[1, 1] = 1; this[1, 2] = 0; this[1, 3] = 0.0f;
            this[2, 0] = 0; this[2, 1] = 0; this[2, 2] = 1; this[2, 3] = 0.0f;
            this[3, 0] = 0; this[3, 1] = 0; this[3, 2] = 0; this[3, 3] = 1.0f;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FMatrix Multiply(ref FMatrix This,ref FMatrix Other);

        /**
         * Gets the result of multiplying a Matrix to this.
         *
         * @param Other The matrix to multiply this by.
         * @return The result of multiplication.
         */
        public static FMatrix operator* (FMatrix This,FMatrix Other)
        {
            return Multiply(ref This,ref Other);
        }

        /**
         * Gets the result of adding a matrix to this.
         *
         * @param Other The Matrix to add.
         * @return The result of addition.
         */
        public static FMatrix operator+ (FMatrix This,FMatrix Other)
        {
            FMatrix ResultMat = new FMatrix();

	        for(int X = 0;X < 4;X++)
	        {
		        for(int Y = 0;Y < 4;Y++)
		        {
			        ResultMat[X,Y] = This[X,Y]+Other[X,Y];
		        }
	        }

	        return ResultMat;
        }

        /** 
          * This isn't applying SCALE, just multiplying float to all members - i.e. weighting
          */
        public static FMatrix operator* (FMatrix This,float Other)
        {
            FMatrix ResultMat = new FMatrix();

	        for(int X = 0;X < 4;X++)
	        {
		        for(int Y = 0;Y < 4;Y++)
		        {
			        ResultMat[X,Y] = This[X,Y]*Other;
		        }
	        }

	        return ResultMat;
        }

        /**
         * Checks whether two matrix are identical.
         *
         * @param Other The other matrix.
         * @return true if two matrix are identical, otherwise false.
         */
        public static bool operator==(FMatrix This,FMatrix Other)
        {
            return This.Equals(Other);
        }

        /**
         * Checks whether another Matrix is equal to this, within specified tolerance.
         *
         * @param Other The other Matrix.
         * @param Tolerance Error Tolerance.
         * @return true if two Matrix are equal, within specified tolerance, otherwise false.
         */
        public override bool Equals(object Obj)
        {
            FMatrix Other = (FMatrix)Obj;
            float Tolerance=Const.KINDA_SMALL_NUMBER;
            for(int X = 0;X < 4;X++)
	        {
		        for(int Y = 0;Y < 4;Y++)
		        {
			        if( FMath.Abs(this[X,Y] - Other[X,Y]) > Tolerance )
			        {
				        return false;
			        }
		        }
	        }

	        return true;
        }
        public override int GetHashCode()
        { return base.GetHashCode(); }
        /**
         * Checks whether another Matrix is not equal to this, within specified tolerance.
         *
         * @param Other The other Matrix.
         * @return true if two Matrix are not equal, within specified tolerance, otherwise false.
         */
        public static bool operator!=(FMatrix This,FMatrix Other)
        {
            return !This.Equals(Other);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FVector4 TransformFVector4(ref FMatrix This,ref FVector4 V);
        // Homogeneous transform.
        public FVector4 TransformFVector4(FVector4 V)
        {
            return TransformFVector4(ref this,ref V);
        }

        /** Transform a location - will take into account translation part of the FMatrix. */
        public FVector4 TransformPosition(FVector V)
        {
            return TransformFVector4(new FVector4(V.X,V.Y,V.Z,1.0f));
        }

        /** Inverts the matrix and then transforms V - correctly handles scaling in this matrix. */
        public FVector InverseTransformPosition(FVector V)
        {
            FMatrix InvSelf = this.InverseFast();
	        return InvSelf.TransformPosition(V);
        }

        /** 
         *	Transform a direction vector - will not take into account translation part of the FMatrix. 
         *	If you want to transform a surface normal (or plane) and correctly account for non-uniform scaling you should use TransformByUsingAdjointT.
         */
        public FVector4 TransformVector(FVector V)
        {
            return TransformFVector4(new FVector4(V.X,V.Y,V.Z,0.0f));
        }

        /** 
         *	Transform a direction vector by the inverse of this matrix - will not take into account translation part.
         *	If you want to transform a surface normal (or plane) and correctly account for non-uniform scaling you should use TransformByUsingAdjointT with adjoint of matrix inverse.
         */
         public FVector InverseTransformVector(FVector V)
         {
             FMatrix InvSelf = this.InverseFast();
	         return InvSelf.TransformVector(V);
         }

        // Transpose.

        public FMatrix GetTransposed()
        {
            FMatrix	Result = new UnrealEngine.FMatrix();

	        Result[0,0] = this[0,0];
	        Result[0,1] = this[1,0];
	        Result[0,2] = this[2,0];
	        Result[0,3] = this[3,0];

	        Result[1,0] = this[0,1];
	        Result[1,1] = this[1,1];
	        Result[1,2] = this[2,1];
	        Result[1,3] = this[3,1];

	        Result[2,0] = this[0,2];
	        Result[2,1] = this[1,2];
	        Result[2,2] = this[2,2];
	        Result[2,3] = this[3,2];

	        Result[3,0] = this[0,3];
	        Result[3,1] = this[1,3];
	        Result[3,2] = this[2,3];
	        Result[3,3] = this[3,3];

	        return Result;
        }

        // @return determinant of this matrix.

        public float Determinant()
        {
            	return	this[0,0] * (
				this[1,1] * (this[2,2] * this[3,3] - this[2,3] * this[3,2]) -
				this[2,1] * (this[1,2] * this[3,3] - this[1,3] * this[3,2]) +
				this[3,1] * (this[1,2] * this[2,3] - this[1,3] * this[2,2])
				) -
			this[1,0] * (
				this[0,1] * (this[2,2] * this[3,3] - this[2,3] * this[3,2]) -
				this[2,1] * (this[0,2] * this[3,3] - this[0,3] * this[3,2]) +
				this[3,1] * (this[0,2] * this[2,3] - this[0,3] * this[2,2])
				) +
			this[2,0] * (
				this[0,1] * (this[1,2] * this[3,3] - this[1,3] * this[3,2]) -
				this[1,1] * (this[0,2] * this[3,3] - this[0,3] * this[3,2]) +
				this[3,1] * (this[0,2] * this[1,3] - this[0,3] * this[1,2])
				) -
			this[3,0] * (
				this[0,1] * (this[1,2] * this[2,3] - this[1,3] * this[2,2]) -
				this[1,1] * (this[0,2] * this[2,3] - this[0,3] * this[2,2]) +
				this[2,1] * (this[0,2] * this[1,3] - this[0,3] * this[1,2])
				);
        }

        /** @return the determinant of rotation 3x3 matrix */
        public float RotDeterminant()
        {
            	return	
		this[0,0] * (this[1,1] * this[2,2] - this[1,2] * this[2,1]) -
		this[1,0] * (this[0,1] * this[2,2] - this[0,2] * this[2,1]) +
		this[2,0] * (this[0,1] * this[1,2] - this[0,2] * this[1,1]);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FMatrix InverseFast(ref FMatrix This);
        /** Fast path, doesn't check for nil matrices in final release builds */
        public FMatrix InverseFast()
        {
            return InverseFast(ref this);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FMatrix Inverse(ref FMatrix This);
        /** Fast path, and handles nil matrices. */
        public FMatrix Inverse()
        {
            return Inverse(ref this);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FMatrix TransposeAdjoint(ref FMatrix This);
        public FMatrix TransposeAdjoint()
        {
            return TransposeAdjoint(ref this);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void RemoveScaling(ref FMatrix This, float Tolerance);
        // NOTE: There is some compiler optimization issues with WIN64 that cause FORCEINLINE to cause a crash
        // Remove any scaling from this matrix (ie magnitude of each row is 1) with error Tolerance
        public void RemoveScaling(float Tolerance=Const.SMALL_NUMBER)
        {
            RemoveScaling(ref this,Tolerance);
        }

        // Returns matrix after RemoveScaling with error Tolerance
        public FMatrix GetMatrixWithoutScale(float Tolerance=Const.SMALL_NUMBER)
        {
            FMatrix Result = this;
	        Result.RemoveScaling(Tolerance);
	        return Result;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FVector ExtractScaling(ref FMatrix This,float Tolerance);
        /** Remove any scaling from this matrix (ie magnitude of each row is 1) and return the 3D scale vector that was initially present with error Tolerance */
        public FVector ExtractScaling(float Tolerance=Const.SMALL_NUMBER)
        {
            return ExtractScaling(ref this,Tolerance);
        }

        /** return a 3D scale vector calculated from this matrix (where each component is the magnitude of a row vector) with error Tolerance. */
        public FVector GetScaleVector(float Tolerance=Const.SMALL_NUMBER)
        {
            FVector Scale3D = new FVector(1,1,1);

	        // For each row, find magnitude, and if its non-zero re-scale so its unit length.
	        for(int i=0; i<3; i++)
	        {
		        float SquareSum = (this[i,0] * this[i,0]) + (this[i,1] * this[i,1]) + (this[i,2] * this[i,2]);
		        if(SquareSum > Tolerance)
		        {
			        Scale3D[i] = (float)FMath.Sqrt(SquareSum);
		        }
		        else
		        {
			        Scale3D[i] = 0.0f;
		        }
	        }

	        return Scale3D;
        }

        // Remove any translation from this matrix
        public FMatrix RemoveTranslation()
        {
            FMatrix Result = this;
	        Result[3,0] = 0.0f;
	        Result[3,1] = 0.0f;
	        Result[3,2] = 0.0f;
	        return Result;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FMatrix ConcatTranslation(ref FMatrix This,ref FVector Translation);
        /** Returns a matrix with an additional translation concatenated. */
        public FMatrix ConcatTranslation(FVector Translation)
        {
            return ConcatTranslation(ref this,ref Translation);
        }

        /** Scale the translation part of the matrix by the supplied vector. */
        public void ScaleTranslation(FVector InScale3D)
        {
            this[3,0] *= InScale3D.X;
	        this[3,1] *= InScale3D.Y;
	        this[3,2] *= InScale3D.Z;
        }

        /** @return the maximum magnitude of any row of the matrix. */
        public float GetMaximumAxisScale()
        {
            	float MaxRowScaleSquared = FMath.Max(
		        GetScaledAxis( EAxis.X ).SizeSquared(),
		        FMath.Max(
			        GetScaledAxis( EAxis.Y ).SizeSquared(),
			        GetScaledAxis( EAxis.Z ).SizeSquared()
			        )
		        );
	        return (float)FMath.Sqrt(MaxRowScaleSquared);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  FMatrix ApplyScale(ref FMatrix This,float Scale);
        /** Apply Scale to this matrix **/
        public FMatrix ApplyScale(float Scale)
        {
            return ApplyScale(ref this,Scale);
        }

        // @return the origin of the co-ordinate system
        public FVector GetOrigin()
        {
            return new FVector(this[3,0],this[3,1],this[3,2]);
        }

        /**
         * get axis of this matrix scaled by the scale of the matrix
         *
         * @param i index into the axis of the matrix
         * @ return vector of the axis
         */
        public FVector GetScaledAxis(EAxis InAxis)
        {
            switch ( InAxis )
	        {
	        case EAxis.X:
		        return new FVector(this[0,0], this[0,1], this[0,2]);

	        case EAxis.Y:
		        return new FVector(this[1,0], this[1,1], this[1,2]);

	        case EAxis.Z:
		        return new FVector(this[2,0], this[2,1], this[2,2]);

	        default:
		        return FVector.ZeroVector;
	        }
        }

        /**
         * get axes of this matrix scaled by the scale of the matrix
         *
         * @param X axes returned to this param
         * @param Y axes returned to this param
         * @param Z axes returned to this param
         */
        public void GetScaledAxes(out FVector X,out  FVector Y,out  FVector Z)
        {
            X.X = this[0,0]; X.Y = this[0,1]; X.Z = this[0,2];
	        Y.X = this[1,0]; Y.Y = this[1,1]; Y.Z = this[1,2];
	        Z.X = this[2,0]; Z.Y = this[2,1]; Z.Z = this[2,2];
        }

        /**
         * get unit length axis of this matrix
         *
         * @param i index into the axis of the matrix
         * @return vector of the axis
         */
        public FVector GetUnitAxis(EAxis InAxis)
        {
            return GetScaledAxis( InAxis ).GetSafeNormal();
        }

        /**
         * get unit length axes of this matrix
         *
         * @param X axes returned to this param
         * @param Y axes returned to this param
         * @param Z axes returned to this param
         */
        public void GetUnitAxes(out FVector X,out  FVector Y,out  FVector Z)
        {
            GetScaledAxes(out X,out Y,out Z);
	        X.Normalize();
	        Y.Normalize();
	        Z.Normalize();
        }

        /**
         * set an axis of this matrix
         *
         * @param i index into the axis of the matrix
         * @param Axis vector of the axis
         */
        public void SetAxis( int i,FVector Axis )
        {
            this[i,0] = Axis.X;
	        this[i,1] = Axis.Y;
	        this[i,2] = Axis.Z;
        }

        // Set the origin of the coordinate system to the given vector
        public void SetOrigin(FVector NewOrigin )
        {
            this[3,0] = NewOrigin.X;
	        this[3,1] = NewOrigin.Y;
	        this[3,2] = NewOrigin.Z;
        }

        /**
         * get a column of this matrix
         *
         * @param i index into the column of the matrix
         * @return vector of the column 
         */
        public FVector GetColumn(int i)
        {
            return new FVector(this[0,i], this[1,i], this[2,i]);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  FRotator Rotator(ref FMatrix This);
        /** @return rotator representation of this matrix */
        public FRotator Rotator()
        {
            return Rotator(ref this);
        }

        /** 
         * Transform a rotation matrix into a quaternion.
         *
         * @warning rotation part will need to be unit length for this to be right!
         */
        public FQuat ToQuat()
        {
            FQuat Result = new FQuat(this);
	        return Result;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumNearPlane(ref FMatrix This,out FPlane OutPlane);
        // Frustum plane extraction.
        /** @param OutPlane the near plane of the Frustum of this matrix */
        public bool GetFrustumNearPlane(out FPlane OutPlane)
        {
            return GetFrustumNearPlane(ref this,out OutPlane);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumFarPlane(ref FMatrix This,out FPlane OutPlane);
        /** @param OutPlane the far plane of the Frustum of this matrix */
        public bool GetFrustumFarPlane(out FPlane OutPlane)
        {
            return GetFrustumFarPlane(ref this,out OutPlane);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumLeftPlane(ref FMatrix This,out FPlane OutPlane);
        /** @param OutPlane the left plane of the Frustum of this matrix */
        public bool GetFrustumLeftPlane(out FPlane OutPlane)
        {
            return GetFrustumLeftPlane(ref this,out OutPlane);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumRightPlane(ref FMatrix This,out FPlane OutPlane);
        /** @param OutPlane the right plane of the Frustum of this matrix */
        public bool GetFrustumRightPlane(out FPlane OutPlane)
        {
            return GetFrustumRightPlane(ref this,out OutPlane);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumTopPlane(ref FMatrix This,out FPlane OutPlane);
        /** @param OutPlane the top plane of the Frustum of this matrix */
        public bool GetFrustumTopPlane(out FPlane OutPlane)
        {
            return GetFrustumTopPlane(ref this,out OutPlane);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static  bool GetFrustumBottomPlane(ref FMatrix This,out FPlane OutPlane);
        /** @param OutPlane the bottom plane of the Frustum of this matrix */
        public bool GetFrustumBottomPlane(out FPlane OutPlane)
        {
            return GetFrustumBottomPlane(ref this,out OutPlane);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void Mirror(ref FMatrix This, int MirrorAxis, int FlipAxis);
        /**
         * Utility for mirroring this transform across a certain plane, and flipping one of the axis as well.
         */
        public void Mirror(EAxis MirrorAxis, EAxis FlipAxis)
        {
            Mirror(ref this, (int)MirrorAxis, (int)FlipAxis);
        }

        /**
         * Get a textual representation of the vector.
         *
         * @return Text describing the vector.
         */
        public override string ToString()
        {
            string Output = "";

	        Output += string.Format("[{0} {1} {2} {3}] ", this[0,0], this[0,1], this[0,2], this[0,3]);
            Output += string.Format("[{0} {1} {2} {3}] ", this[1,0], this[1,1], this[1,2], this[1,3]);
            Output += string.Format("[{0} {1} {2} {3}] ", this[2,0], this[2,1], this[2,2], this[2,3]);
            Output += string.Format("[{0} {1} {2} {3}] ", this[3,0], this[3,1], this[3,2], this[3,3]);

	        return Output;
        }
    }
}
