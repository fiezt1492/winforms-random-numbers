using System.Drawing;
using System;

namespace test
{
    public partial class Form1 : Form
    {

        List<int> listNumbers = new List<int>();
        bool isSorted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            lbNumbers.Text = "";
            listNumbers.Clear();
            isSorted = false;
            int length = 10000;
            for (int i = 0; i < length; i++)
            {
                Random rnd = new Random();
                listNumbers.Add(rnd.Next(0, 10));
            }
            MessageBox.Show($"Da sinh xong {length} so!");
            lbNumbers.Text = string.Join("", listNumbers);
            listNumbersLength.Text = "Do dai: " + lbNumbers.Text.Length.ToString();
        }

        private void Swap(List<int> ln, int x, int y)
        {
            int temp = ln[x];
            ln[x] = ln[y];
            ln[y] = temp;
        }

        private int Partition(List<int> ln, int low, int high)
        {
            float pivot = ln[high];
            int right = high - 1;
            int left = low;

            while (true)
            {
                while (left <= right && ln[left] < pivot)
                    left++;
                while (right >= left && ln[right] > pivot)
                    right--;
                if (left >= right)
                    break;
                Swap(ln, left, right);
                left++;
                right--;
            }
            Swap(ln, left, high);
            return left;
        }

        private void QuickSort(List<int> ln, int low, int high)
        {
            if (low >= high) return;
            else
            {
                int pivotIndex = Partition(ln, low, high);
                QuickSort(ln, low, pivotIndex - 1);
                QuickSort(ln, pivotIndex + 1, high);
            }
        }

        int binarySearch(List<int> arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);
                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }

        int demSo(List<int> array, int x)
        {
            int indexToBound = binarySearch(array, 0, array.Count - 1, x);

            if (indexToBound == -1)
                return 0;

            int dem = 1;
            for (int i = indexToBound; i > 0; i--)
            {
                if (array[i] != array[i - 1]) break;
                dem++;
            }
            for (int i = indexToBound; i < array.Count - 1; i++)
            {
                if (array[i] != array[i + 1]) break;
                dem++;
            }
            return dem;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            SapXep();
            lbNumbers.Text = string.Join("", listNumbers);
            listNumbersLength.Text = "Do dai: " + lbNumbers.Text.Length.ToString();
        }

        void SapXep()
        {
            if (listNumbers.Count == 0)
            {
                MessageBox.Show("Chua sap xep do khong co gia tri!");
                return;
            }
            if (isSorted != true)
            {
                QuickSort(listNumbers, 0, listNumbers.Count - 1);
                MessageBox.Show("Da sap xep!");
                isSorted = true;
            }
        }

        private void btnDemSo_Click(object sender, EventArgs e)
        {
            SapXep();
            Dictionary<int, int> demSoMap = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                demSoMap.Add(i, demSo(listNumbers, i));
            }
            if (demSoMap.Count != 0) MessageBox.Show("Da dem xong!");
            else MessageBox.Show("Khong co so nao duoc dem.");
            int tong = demSoMap.Values.Sum();
            lbNumbers.Text = string.Join("\n", demSoMap);
            lbNumbers.Text += "\nTong so da dem: " + tong;
        }
    }
}

