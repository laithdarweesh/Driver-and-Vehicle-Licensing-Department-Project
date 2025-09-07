using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid NewGuid = Guid.NewGuid();
            return NewGuid.ToString();
        }

        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            string FileName = SourceFile;
            FileInfo fileinfo = new FileInfo(FileName);
            string Extension = fileinfo.Extension;

            return GenerateGUID() + Extension;
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Error while Creating Folder Path" + Ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static bool CopyImageToProjectImagesFolder(ref string SourceImageFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"C:\DVLD_Person_Images\";

            if(!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string NewImagePath = DestinationFolder + ReplaceFileNameWithGUID(SourceImageFile);

            try
            {
                File.Copy(SourceImageFile, NewImagePath, true);
            }
            catch(IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceImageFile = NewImagePath;
            return true;
        }
    }
}
