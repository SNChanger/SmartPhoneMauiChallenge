#���̃v���W�F�N�g�ɂ���

Spajam�ł݂�Ȃ��X�}�z�A�v����i�߂Ă����������Ă݂���B

## �Z�p�\��

### �J����

VisualStudio2022�Ή�

### �e�y�[�W�̍쐬

.Net MAUI�̃e���v���[�g�t�@�C�����g���č쐬

### �����쐬���̎Q�l����

https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/

### ���j���[��ʂ̍ŏI�I�ȑJ��(ReleasePlan LastFlow)
```mermaid
flowchart LR
    subgraph App
        subgraph Menu
           userMemoTab -->userMemoDetail
           itemListTab -->itemList
           facilitySearchTab -->facilitySearchDisplay
           medicinedinputFormTab --> medicinedinputForm
        end
    end
User --> App --> Display
```
#### �e��ʂ̎����\����e
##### �ߋ��̎�f���e�ꗗ
##### ��ʑ��T�v
���͉�ʂŕۑ��������e�̎�f�����ꗗ��\������
��f�������N���b�N���邱�Ƃŏڍ׉�ʂ֑J�ڂ���
##### �f�[�^�J��
```mermaid
sequenceDiagram
    participant �C�x���g���v���O����
    participant ����ꗗ�擾
    participant �ۑ���
    �C�x���g���v���O����->>����ꗗ�擾: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���Ăяo��
    ����ꗗ�擾->>�ۑ���: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���߂����s
    �ۑ���->>����ꗗ�擾: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���߂̎��s���ʂ�ԋp
    ����ꗗ�擾->>�C�x���g���v���O����: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���ʂ�ԋp
    loop �P�y�[�W�ɕ\������f�[�^��
    �C�x���g���v���O����->>�C�x���g���v���O����: �擾�����ꗗ�ɂ��āAXAML���ɔ��f����
    end
```
##### �����������
##### ��ʑ��T�v
�w�肵�������ŁA��������炦����
�\�����ꂽ���������N���b�N���邱�Ƃŏڍ׉�ʂ֑J�ڂ���
##### �f�[�^�J��
```mermaid
sequenceDiagram
    participant �C�x���g���v���O����
    participant �����T�v�ꗗ
    participant �ۑ���
    �C�x���g���v���O����->>�C�x���g���v���O����: �~��������Ⳃ̓��e�ɍ��킹���A������������͂���
    �C�x���g���v���O����->>�����T�v�ꗗ�擾: �����T�v�ꗗ�擾���Ăяo��
    �����T�v�ꗗ�擾->>�ۑ���: �����T�v�ꗗ�擾���߂����s
    �ۑ���->>�����T�v�ꗗ�擾: �����T�v�ꗗ�擾���߂����s���ʂ�ԋp
    �����T�v�ꗗ�擾->>�C�x���g���v���O����: �������ʂɉ�������ʓ��e��ԋp����
    loop �P�y�[�W�ɕ\������f�[�^��
    �C�x���g���v���O����->>�C�x���g���v���O����: �擾�����������ɂ��āAXAML���ɔ��f����
    end
```


##### ��f���ʓ��͉��
##### ��ʑ��T�v
��f�������̓��e����͂���
###### ���͍���
�\�����ꂽ���������N���b�N���邱�Ƃŏڍ׉�ʂ֑J�ڂ���

   ��ǖ�(�Z�Z�x�X��)
   ��Ë@�֖�(������w�a�@)
   �����O(�w�����̖��O�@�㗝�l�Ƃ��{�l�̖��O�Ƃ�)
   ���N����(�Ώێ҂̒a���� �A�J�E���g�y�[�W���ł�����ړ��\��)


##### �f�[�^�J��
```mermaid
sequenceDiagram
    participant �C�x���g���v���O����
    participant ��f���e�ۑ�
    participant �ۑ���(��f���ʕۑ�DB)
    �C�x���g���v���O����->>�C�x���g���v���O����: ��f�����Ƃ��̓��͓��e�𔽉f����
    �C�x���g���v���O����->>��f���e�ۑ�: ��f�����Ƃ��̓��e�������ɁA��f���e�ۑ����Ăяo�� 
    ��f���e�ۑ�->>�ۑ���: ��f���ʕۑ�DB�ւ̔��f���������s
    �ۑ���->>��f���e�ۑ�: ��f���e�ۑ������s���ʂ�ԋp
    ��f���e�ۑ�->>�C�x���g���v���O����: ���͓��e�̕ۑ����ʂ�ԋp
    �C�x���g���v���O����->>�C�x���g���v���O����: �ۑ����s���ʂ���ʂ̃_�C�A���O�ɔ��f����
```









