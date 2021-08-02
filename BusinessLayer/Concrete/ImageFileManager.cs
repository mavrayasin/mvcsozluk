using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DateAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager :IImageFileService
    {
        IImageFileDal _imagefiledal;

        public ImageFileManager(IImageFileDal imagefiledal)
        {
            _imagefiledal = imagefiledal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefiledal.List();
        }
    }
}
