## QUI ĐỊNH VỀ CHUẨN LẬP TRÌNH C#
 TỔ CHỨC TẬP TIN, THƯ MỤC  
 
- Đặt tên tập tin ngắn gọn
- Lưu mỗi lớp trong một tập tin  riêng biệt và tên tập tin phải trùng với tên lớp.
- Mỗi namespace được đặt trong một thư mục riêng, phân cấp mục theo phân cấp của namespace   

KHOẢNG TRẮNG
- Không được gõ khoảng trắng ở đầu dòng lệnh
- Giữa các phép toán và toán hạng phải có khoảng trắng 
- Sau dấu phẩy phải có một khoảng trắng(trường hợp truyền tham sô cho hàm).  

CHÚ THÍCH
- Chú thích 1 đoạn: sử dụng cặp dấu/*...*/
- Chú thích một dòng: Sử dụng//  

KIỂU DỮ LIỆU TRONG C#  
- Trong ngôn ngữ lập trình nói chung và ngôn ngữ c# nói riêng người ta chia thành các kiểu dữ liệu khác nhau để phục vụ nhu cầu của người lập trình tùy theo mục đích sử dụng.
- Kiểu dữ liệu khác nhau ở việc kích thước cấp phát vùng nhớ, việc hiểu được các kiểu dữ liệu sẽ giúp các bạn sử dụng kiểu nào đúng mục đích, tiết kiệm vùng nhớ đó là việc cần thiết.
- Các nhớ đơn giản miền giá trị của từng kiểu các bạn có thể từ kích thước byte chuyển về bit sau đó đưa ra miền giá trị 2^n. Trong đó n là số bit của kiểu dữ liệu đó. 

KHAI BÁO BIẾN TRONG C#  
- Khai báo biến là việc người lập trình khai báo chỉ ra cho máy tính cần cấp phát một vùng nhớ để lưu trữ thông tin phục vụ tính toán, so sánh, xử lý thông tin,…mà người lập trình mong muốn.  
- Cú pháp khai báo biến như sau:
  [Kiểu dữ liệu] [Tên biến] = [Giá trị mặc định];  
  
QUY TẮC ĐẶT TÊN BIẾN TRONG C#  
Trong quá trình làm việc với c#, việc đặt theo đúng quy định tên biến rất quan trọng để giúp người khác đọc hoặc review code có thể dễ hiểu, nhận biết nhất. Sau đây là các quy tắc về việc đặt tên biến như sau:  

-Tên biến là một chuỗi kí tự liên tiếp không có khoảng cách, tiếng việt có dấu và chứa kí tự đặc biệt  
-Tên biến phải bắt đầu bằng kí tự không phải dạng số hoặc dấu _  
-Tên biến không được đặt trùng với từ khóa  
-Tên biến phân biệt hoa thường  
-Tên biến đặt ngắn gọn, dễ hiểu và mô tả được ý nghĩa của việc sử dụng
