#nullable enable
using System;
using System.Drawing;
using Cognex.VisionPro;

namespace HardWareNet.Base;

public class ImageData:IDisposable
{
    public ICogImage? CogImage { get; set; }

    public ImageData()
    {
        CogImage = null;
    }
    public ImageData(ICogImage? externCogImage)
    {
        CogImage = externCogImage;
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // 释放托管资源
                CogImage = null;
            }
            // 释放非托管资源（如果有）
            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~ImageData()
    {
        Dispose(false);
    }

    public static ICogImage? GetMonoImage(int nHeight, int nWidth, IntPtr pImageBuf)
    {
        try
        {
            CogImage8Root cogImage8Root = new CogImage8Root();
            cogImage8Root.Initialize(nWidth, nHeight, pImageBuf, nWidth, null);
            CogImage8Grey cogImage8Grey = new CogImage8Grey();
            cogImage8Grey.SetRoot(cogImage8Root);
            return cogImage8Grey.ScaleImage(nWidth, nHeight);
        }
        catch
        {
            return null;
        }
    }

    public static ICogImage? ConvertCogGreyImage(Bitmap bitmap)
    {
        try
        {
            return new CogImage8Grey(bitmap);
        }
        catch
        {
            return null;
        }
    }
    public static ICogImage? ConvertCogGreyImage(int nHeight, int nWidth, IntPtr pImageBuf)
    {
        ICogImage? tmpImage;
        try
        {
            CogImage8Root cogImage8Root = new CogImage8Root();
            cogImage8Root.Initialize(nWidth, nHeight, pImageBuf, nWidth, null);
            CogImage8Grey cogImage8Grey = new CogImage8Grey();
            cogImage8Grey.SetRoot(cogImage8Root);
            tmpImage = cogImage8Grey.ScaleImage(nWidth, nHeight);
            GC.Collect();
            //if (enPixelType == MvGvspPixelType.PixelType_Gvsp_Mono8)
            //{

            //}
            //else
            //{
            //    uint m_nRowStep = nWidth * nHeight;
            //    CogImage8Root image0 = new CogImage8Root();
            //    IntPtr ptr0 = new IntPtr(pImageBuf.ToInt64());
            //    image0.Initialize((int)nWidth, (int)nHeight, ptr0, (int)nWidth, null);
            //    CogImage8Root image1 = new CogImage8Root();
            //    IntPtr ptr1 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep);
            //    image1.Initialize((int)nWidth, (int)nHeight, ptr1, (int)nWidth, null);
            //    CogImage8Root image2 = new CogImage8Root();
            //    IntPtr ptr2 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep * 2);
            //    image2.Initialize((int)nWidth, (int)nHeight, ptr2, (int)nWidth, null);
            //    CogImage24PlanarColor colorImage = new CogImage24PlanarColor();
            //    colorImage.SetRoots(image0, image1, image2);
            //    tmpImage = colorImage.ScaleImage((int)nWidth, (int)nHeight);
            //    GC.Collect();
            //}
        }
        catch (Exception)
        {
            return null;
        }
        return tmpImage;
    }
    public static Cognex.VisionPro.ICogImage ConvertCogRgbImage(Bitmap bitmap)
    {
        try
        {
            return new CogImage24PlanarColor(bitmap);
        }
        catch
        {
            return null;
        }
    }
    public static ICogImage? ConvertCogRgbImage(int nHeight, int nWidth, IntPtr pImageBuf)
    {
        try
        {
            uint m_nRowStep = (uint)(nWidth * nHeight);
            CogImage8Root image0 = new CogImage8Root();
            IntPtr ptr0 = new IntPtr(pImageBuf.ToInt64());
            image0.Initialize(nWidth, nHeight, ptr0, nWidth, null);
            CogImage8Root image1 = new CogImage8Root();
            IntPtr ptr1 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep);
            image1.Initialize(nWidth, nHeight, ptr1, nWidth, null);
            CogImage8Root image2 = new CogImage8Root();
            IntPtr ptr2 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep * 2);
            image2.Initialize(nWidth, nHeight, ptr2, nWidth, null);
            CogImage24PlanarColor colorImage = new CogImage24PlanarColor();
            colorImage.SetRoots(image0, image1, image2);
            return colorImage.ScaleImage(nWidth, nHeight);
        }
        catch
        {
            return null;
        }
    }

}

