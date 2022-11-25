// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <MvvmCross/MvvmCross.h>
#import <UIKit/UIKit.h>
#import <FFImageLoading/FFImageLoading.h>


@interface ListViewCell : UITableViewCell {
	UISwitch *_FavSwitch;
	MvxCachedImageView *_ListImg;
	UITextView *_NewsDisc;
	UILabel *_Newstitle;
}

@property (nonatomic, retain) IBOutlet UISwitch *FavSwitch;

@property (nonatomic, retain) IBOutlet MvxCachedImageView *ListImg;

@property (nonatomic, retain) IBOutlet UITextView *NewsDisc;

@property (nonatomic, retain) IBOutlet UILabel *Newstitle;

@end
