
namespace EnglishRandomTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt.Font = new Font("Arial", 32);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
                 "Cô ấy làm tôi vội vã",
                "Tôi đã có quyết định của mình",
                "Họ đã đồng ý làm việc với nhau",
                "Tom tập trung vào công việc",
                "Anh ấy đi vào qua cửa sổ",
                "Tôi không đủ khả năng mua một chiếc xe đắt tiền như vậy",
                "Bạn làm tôi hạnh phúc",
                "Tôi có thể đặt chỗ trước không"
            };
            string[] day2 =
            {
                 "Lên ngựa",
                "Chúng ta hãy xuống xe",
                "Khi nào bạn về nhà",
                "Anh ấy có phòng riêng",
                "Bạn có nghĩ là anh ấy tự mình làm việc đó không",
                "Đó là ý kiến ​​hay",
                "Bạn nghĩ bạn là ai",
                "Anh ấy vẫn còn sống"
            };
            string[] day3 =
            {
                "Tôi phải đi ngay cả khi trời mưa",
                "Anh ấy phải làm việc ngay cả vào chủ nhật",
                "tôi muốn xem phim",
                "Nhiều bạn bè đã đến tiễn tôi",
                "Cả hai đều là giáo viên giỏi",
                "Tôi không đồng ý với chính sách của chính phủ",
                "Bạn có biết cách sử dụng máy tính không?"
            };
            string[] day4 =
            {
                "Tất cả họ đều giống nhau phải không",
                "Kim và tôi cùng tuổi",
                "Bạn đã nói gì?",
                "Bạn phải học cả đời",
                "Dựa vào bức tường này",
                "Tôi cảm thấy như một người khác"
            };
            string[] day5 =
            {
                "Tôi sẽ ra ngoài 1 lúc",
                "Tôi đã gặp anh ấy khi anh ấy ở Nhật Bản",
                "Tôi cần thêm thời gian",
                "Tôi cần lời khuyên",
                "Chúng tôi yêu nhau",
                "Đánh răng sau mỗi bữa ăn",
                "Quyển sách này quá cũ",
                "Bố mẹ tôi đã già",
                "Bạn có công việc bán thời gian không?",
                "Tôi tự hào là một phần của dự án này"
            };
            string[] day6 = {
                "Anh ấy đã đi du lịch khắp thế giới",
                "Đó là những gì tôi nghĩ",
                "Tôi tưởng anh ấy bị bệnh",
                "Tôi hơi đói",
                "Tôi có một ít tiền",
                "Tôi đã không gặp Tom từ năm 1988",
                "Trời đã mưa từ sáng",
                "Anh đặt hành lý xuống",
                "Ngôi nhà đang cháy"
            };
            string[] day7 =
            {
                "Máy ảnh của tôi khác với máy ảnh của bạn",
                "Chúng tôi đã tìm thấy anh ấy còn sống",
                "Tôi đã ở nhà",
                "Không nơi nào giống như ở nhà",
                "Tôi sống cách nhà ga 200 mét"
            };
            string[] day8 =
            {
                "Chào, tôi đã thấy 1 quảng cáo trên tờ báo cho cái máy pha cà phê này. Tôi có thể tìm nó ở đâu?"
            };
            string[] day9 =
            {
                "Tôi xin lỗi quý ngài cái máy pha cà phê chuyên dùng này hiện nay đã bán hết. Quý khách có quan tâm tới mẫu khác không?"
            };
            string[] day10 = {
                "Không, đó là cái tôi thật sự muốn. Mày có biết liệu rằng cửa hàng khác của mày còn nó trong kho không."
            };
            string[] day11 =
            {
                "Có một chi nhánh khác của Carter Appliances cách đây khoảng 20 phút, và máy tính hiển thị rằng cửa hàng có nó trong kho. Tạo sao mày không đến đó kiểm tra."
            };
            string[] day12 =
            {
                "Tôi nghĩ chúng ta nên cập nhật tài liệu quảng cáo cho khách sạn trước khi bắt đầu mùa du lịch. Tài liệu hiện tại không liệt kê giá mới của chúng ta"
            };
            string[] day13 =
            {
                "Tôi đồng ý—và, bạn biết đấy, tờ rơi cũng cần được làm lại. Nó thực sự nên bao gồm những bức ảnh mới về các phòng đã được cải tạo"
            };
            string[] day14 =
            {
                "Nhưng tao nghĩ ngân sách của chúng mình có thể lo liệu khoản chi phí thêm không? Việc in một tờ rơi mới sẽ đắt.\n"
                +"Vâng, nhưng nó sẽ giúp chúng ta quảng cáo, và nó giúp chúng ta có thêm đơn đặt hàng"

            };
            string[] dayt15 =
            {
                "Cảm ơn đã mua sắm với chúng tôi tại cửa hàng Marco's Shoes hôm nay. Tổng số tiền của bạn là 200 pe sô\n"
                +"Liệu rằng là tao có thể được hoàn lại tiền thuế không?"
            };
            string[] day16 =
            {
                "Mày có thể nộp lên cơ quan thuế để lấy lại tiền thuế. Hỏi nhân viên hải quan về thủ tục giấy tờ tại cửa khẩu trước khi rời đi."
            };
            string[] day17 =
            {
                "Tao muốn biết liệu rằng Frank Griffin đã xem xét xong ngân sách đề xuất của chúng ta chưa. Hôm nay mày có nghe tin tức gì về anh ấy không?",
                "Không, Tao không. Mày có muốn tao gọi anh ấy không?"
            };
            string[] day18 =
            {
                "Vậy thì tuyệt vời. Mày hỏi ông ấy nếu có bất kỳ vấn đề nào cái mà chúng ta sẽ cần giải quyết ngay lập tức không? Phiên bản cuối cùng của bản đề xuất sẽ tới hạn vào cuối tuần.",
                "Vâng, Tao sẽ nói m biết những gì tao nghe được. Tao sẽ email cho mày ngay khi tao tắt điện thoại với ông ấy."
            };
                    
            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day8, day9, day10, day11, day12, day13, day14, dayt15, day16);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
                "Excuse me. I'm looking for Lee's Lighting",
                "Xin lỗi. Tôi đang tìm cửa hàng đèn của Lee",
                "Just keep going. It's down the street on the left side.",
                "Cứ tiếp tục đi. Nó ở cuối phố bên trái",
                "Come in! I'm Alan Lee",
                "Hãy vào đây! Tôi là Alan Lee",
                "Nice to meet you Mr.Lee",
                "Rất vui được gặp anh Lee",
                "You left your book in my car",
                "Bạn để quên quyển sách của bạn trong xe của tôi",
                "Can you drop it buy my house",
                "Bạn có thể mang nó đến nhà tôi được không?"
            };
            string[] day2 =
            {
                "Can I speak to the manager?",
                "Tôi có thể nói chuyện với người quản lý không?",
                "Yes, can I put you hold for a minute?",
                "Vâng, tôi có thể giữ máy một lát được không?",
                "Who's in charge of deliveries?",
                "Ai là người phụ trách việc giao hàng?",
                "Mr. Smith is.",
                "Là ông Smith"
            };
            string[] day3 =
            {
                "When is the deadline?",
                "Khi nào đến hạn nộp",
                "1 Pm, We're running short on time.",
                "1 giờ chiều, chúng ta đang gấp rút",
                "It's already 12:55 Pm",
                "Bây giờ đã là 12:55 chiều",
                "We're late. Let's get a move on!",
                "Chúng ta muộn rồi. Hãy đi tiếp thôi!",
                "Sorry, what street?",
                "Xin lỗi, đường nào?",
                "Maple street",
                "Maple Street! M for Mexico, A for Apple, P for Pink, L for land, E for English.",
                "Good afternoon, Honda Marketing. How can I help you?",
                "Yes, I would like to buy a car"
            };
            string[] day4 =
            {
                "Who's that on the phone?",
                "Ai là người đang nói chuyện điện thoại thế",
                "It's for you. It's your wife",
                "Nó là của bạn, là vợ bạn",
                "When will you be back?",
                "Khi nào bạn sẽ quay lại",
                "I'll be back in an hour",
                "Tôi sẽ quay lại trong 1 giờ",
                "How's the project comming along?",
                "Dự án tiến triển thế nào rồi",
                "Great, I'm ahead of schedule.",
                "Tốt, Tôi đang đi trước tiến độ",
                "Fine, I'm on schedule",
                "Ổn, tôi đang đi đúng tiến độ",
                "Not good, I'm behind shechule.",
                "Tệ, tôi đang trễ tiến độ"
            };
            string[] day5 =
            {
                "Can we meet today",
                "Chúng ta có thể gặp hôm nay không",
                "Sorry, I'm tied up. How about tomorrow",
                "Xin lỗi, Tôi bận. Ngày mai thì sao",
                "Can you call me back later",
                "Bạn có thể gọi lại tôi sau không",
                "Yes, I'll call me back later. When is a good time",
                "Vâng, tôi sẽ gọi lại sau. Khi nào là thời gian lý tưởng",
                "Why are you so late?",
                "Tại sao bạn đi trễ vậy",
                "The heavy traffic held me up",
                "Giao thông đông đúc giữ tôi lại",
                "How can I help?",
                "Tôi có thể giúp gì",
                "Please move these boxses out of the way",
                "Làm ơn di chuyển những chiếc hộp này sang chỗ khác"
            };
            string[] day6 = {
                "The box is upside down! Please flip it right side up",
                "Oops! Sorry, I will flip right side up",
                "you look so sad",
                "Why is he so sad",
                "His wife just passed away",
                "No wonder he's sad",
                "Let's split the check",
                "No, it's on me. You paid last time",
                "What held you up",
                "I'm so sorry. I was stuck in traffic for an hour"
            };
            string[] day7 =
            {
                "Dad, you forgot my birthday party!",
                "Bố, bố đã quên bữa tiệc sinh nhật của con",
                "I'm sorry Bill, it slipped my mind",
                "Xin lỗi Bill, nó vừa lướt qua tâm trí bố",
                "Where are my lamps? I need it by 5pm!",
                "Cái đèn  của tôi ở đâu",
                "You look so tired",
                "Bạn trông mệt mỏi quá",
                "Yes, I'm under lot of pressure this month",
                "Vâng tôi đang chiụ áp lực lớn trong tháng này",
                "Could you drop this off at shoe repair shop",
                "Bạn có thể mang cái này tới tiệm sửa giày không",
                "Certainly!",
                "Chắc chắn rồi",
                "It will be ready on Thursday.",
                "Nó sẽ sẵn sàng vào thứ năm"
            };
            string[] day8 =
            {
                "Have you called the plumber yet?",
                "Mày đã gọi thợ sửa ống nước chưa",
                "Nope, not yet. It's only 8 o'clock.",
                "Chưa, vẫn chưa. Mới có 8 giờ đúng",
                "The plumber is comming to fix it tomorrow.",
                "Thợ sửa ống nước sẽ đến sửa nó vào ngày mai",
                "Uh huh, you only have to put up with it for one more day.",
                "uh huh, mày chỉ phải chịu đựng nó thêm 1 ngày nữa thôi",
                "Hello, Plumbing? This is an emergency! We need you to come right away.",
                "Chào, Plumbing. Đây là trường hợp khẩn cấp! Chúng tao cần mày tới ngay bây giờ"
            };
            string[] day9 =
            {
                "Maybe a broken pipe caused the problem?",
                "Có thể một ống nước đã bị vỡ gây ra vấn đề",
                "That's right. The problem was caused by a broken pipe",
                "Đúng vậy. Một ống nước bị vỡ đã gây ra vấn đề này",
                "Oh,no! My hair! It's ruined",
                "Ôi không. Tóc của tôi nó bị hỏng rồi",
                "It's not the end of the world. Your hair will grow back.",
                "Chưa tới nổi nào. Tóc của bạn sẽ mọc lại",
                "When will my hair grow back?",
                "Khi nào tóc tôi sẽ mọc lại đây",
                "Tôi hiểu bạn mà. Chúng ta cùng hoàh cảnh"
            };
            string[] day10 =
            {
                "Turn left, then right and left again. THen go straight until Maple Street, then right and left at...",
                "Quẹo trái, sau đó phải và trái 1 lần nữa. Sau đó đi thẳng tới Maple Street, sau đó phải và trái...",
                "I'm not following you. Could you start that again.",
                "Tao không theo kịp mày. Mày có thể nói lại không",
                "Excuse me. Do you have change for a dollar?",
                "Xin lỗi. Mày có tiền lẻ cho 1 đô không",
                "Yes, here you are.",
                "Có, nó ở đây",
                "Mr.Franks, I can't find your office",
                "Ông Franks, Tao không tìm thấy văn phòng của mày",
                "My office is 3 blocks from the train station",
                "Văn phòng tao cách nhà ga 3 tòa nhà"
            };
            string[] day11 =
            {
                "How many sizes do you have?",
                "Mày có bao nhiêu kích cỡ?",
                "This lamp comes in sizes. Small, Medium and Large",
                "Cái đèn này bao gồm 3 size Small, Medium and Large.",
                "How may I help you?",
                "I'd like one chocolate donut please.",
                "I've been waiting for a long time!",
                "Sorry that I'm late",
                "Which one would you like?",
                "I can't make up my mind."
            };
            string[] day12 =
            {
                "Mày mở cửa hàng khi nào?",
                "cheers! Trăm nay hạnh phúc",
                "Nhìn mày vừa làm gì nè",
                "Chúng ta hãy đi ngủ",
                "Dậy! chúng ta đã ngủ quên",
                "Mọi người đã có đủ cho cuộc họp chưa",
                "Mày đâu? Mày đi trễ"
            };
            string[] day13 =
            {
                "Mày biết ông Lee ở đâu không",
                "Anh ấy đã rời đi trong ngày",
                "Anh ấy làm nghề gì để sống?",
                "Tao thích nướng bánh, mày thích ăn. Việc kết hôn với mày là một tình huống đôi bên cùng có lợi",
                "Còn bánh quy nào nữa không?",
                "Tao có thể giúp gì?",
                "Mày có muốn đi xem phim tối nay không"
            };
            string[] day14 =
            {
                "Nay tao nghỉ làm",
                "Nói cho tao về mày",
                "Đồng phục đây, Mày có thể mặc nó trong phòng thay đồ",
                "Mày có thể gọi khách hàng không",
                "Có phiền nếu tôi ngồi vào đây không",
                "Sắp tới sinh nhật ông Lee. Chúng ta hãy hùng 20 đô và mua 1 món quà"
            };
            string[] day15 =
            {
                "Hey, tao đang đi tới West Mall",
                "Cái cà vạt kia và cái này khác nhau gì?",
                "Tại sao mày mua cái này",
                "Chúng tao đã mua cho mày món quà",
                "Mày đi xa trong bao lâu?",
                "Nó là một chặn đường dài, Hãy đổi tài lái xe."
            };
            string[] day16 =
            {
                "Khi chúng mình tới khách sạn, nhắc tao gọi mẹ tao",
                "Mày thấy thời tiết hôm nay thế nào",
                "Ba, con có thể đi với ba không",
                "Thằng đó giỏi về cái gì"
            };
            string[] day17 =
            {
                "Lâu đài cát của mày tiến triển tới đâu rồi",
                "Họ có cá nướng sốt chanh nghe có vẻ ngon",
                "Tao có thể đậu xe ở đây không?",
                "Chuyến đi của mày thế nào?"
            };
            string[] day18 =
            {
                "Tôi đã quên đóng cửa xe",
                "Mày có biết ông Smith ở đâu không?",
                "Xin lỗi.\n Ok, tao có thể giúp gì cho mày",
                "Tình trạng nó còn sử dụng tốt không?"
            };
            string[] day19 =
            {
                "Tao có thể nói chuyện với Tom Smith được không?",
                "Tao muốn nói chuyện với quản lý",
                "Tao sẽ đi Hà Nội",
                "Mày có nghe gì về Linda không",
                "Giao hàng trễ, khách hàng giận ...",
                "Cái này được tính cho cái gì?",
                "Vợ Tom có thai",
                "Tại sao mày lại nộp đơn vào công ty chúng tao"
            };
            string[] day20 =
            {
                "Tao muốn cái thứ hai từ phải qua",
                "Hi Alii, chúng ta vẫn gặp nhau hôm nay như đã hẹn chứ?",
                "Dự báo thời tiết hôm nay thế nào",
                "Hey Ali, tao có thể thử gậy đánh golf của mày được không",
                "Tâm thật tao tốt khi tao chơi golf",
                "Sue Smith. Thật bất ngờ khi gặp mày",
                "Có gì xảy ra với mày vậy"
            };
            string[] day21 =
{
                "Có chuyện gì đang xảy ra vậy?",
                "Tao có thể nói chuyện với Adele được không",
                "Tao muốn mày về nhà trước 8h",
                "Mày nghĩ sao về việc tăng giá của chúng mình",
                "Nó đang giảm giá",
                "Nó cảm giác thật mềm. Nó được làm từ gì vậy?",
                "150 đô á? đó giá cao",
                "Nó có hoạt động không?"
            };
            string[] day22 =
            {
                "Lên đây. Nó dễ lắm",
                "Em có thể đi với anh không, làm ơn",
                "Tommy, anh là 1 kẻ ngu dốt",
                "Mom, con có 1 con cóc đẹp",
                "Má, tôi đã bỏ lỡ xe bus",
                "Có thể nói tôi biết bưu điện ở đâu không",
            };
                
            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }
    }
}
